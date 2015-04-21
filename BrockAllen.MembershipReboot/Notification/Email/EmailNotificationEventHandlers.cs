/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Angular.Core.Modals.Identity;

namespace BrockAllen.MembershipReboot
{
    public class EmailEventHandler<TAccount>
        where TAccount: UserAccount
    {
        IMessageFormatter<TAccount> messageFormatter;
        IMessageDelivery messageDelivery;

        public EmailEventHandler(IMessageFormatter<TAccount> messageFormatter)
            : this(messageFormatter, new SmtpMessageDelivery())
        {
        }

        public EmailEventHandler(IMessageFormatter<TAccount> messageFormatter, IMessageDelivery messageDelivery)
        {
            if (messageFormatter == null) throw new ArgumentNullException("messageFormatter");
            if (messageDelivery == null) throw new ArgumentNullException("messageDelivery");

            this.messageFormatter = messageFormatter;
            this.messageDelivery = messageDelivery;
        }

        public virtual void Process(UserAccountEvent evt, object extra = null)
        {
            Tracing.Information("[{0}] Processing Event: {1}", this.GetType(), evt.GetType());
            
            var data = new Dictionary<string, string>();
            if (extra != null)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(extra))
                {
                    object obj2 = descriptor.GetValue(extra);
                    if (obj2 != null)
                    {
                        data.Add(descriptor.Name, obj2.ToString());
                    }
                }
            }

            var msg = this.messageFormatter.Format(evt, data);
            if (msg != null)
            {
                if (data.ContainsKey("NewEmail"))
                {
                    msg.To = data["NewEmail"];
                }
                else
                {
                    msg.To = evt.Account.Email;
                }
                
                if (!String.IsNullOrWhiteSpace(msg.To))
                {
                    this.messageDelivery.Send(msg);
                }
            }
        }
    }

    public class EmailAccountEventsHandler<T> :
        EmailEventHandler<T>,
        IEventHandler<AccountCreatedEvent>,        
        IEventHandler<PasswordResetRequestedEvent<T>>,
        IEventHandler<PasswordChangedEvent>,
        IEventHandler<PasswordResetSecretAddedEvent>,
        IEventHandler<PasswordResetSecretRemovedEvent>,
        IEventHandler<UsernameReminderRequestedEvent<T>>,
        IEventHandler<AccountClosedEvent>,
        IEventHandler<AccountReopenedEvent>,
        IEventHandler<UsernameChangedEvent>,
        IEventHandler<EmailChangeRequestedEvent>,
        IEventHandler<EmailChangedEvent>,
        IEventHandler<EmailVerifiedEvent>,
        IEventHandler<MobilePhoneChangedEvent>,
        IEventHandler<MobilePhoneRemovedEvent>,
        IEventHandler<CertificateAddedEvent>,
        IEventHandler<CertificateRemovedEvent>,
        IEventHandler<LinkedAccountAddedEvent>,
        IEventHandler<LinkedAccountRemovedEvent>
        where T : UserAccount
    {
        public EmailAccountEventsHandler(IMessageFormatter<T> messageFormatter)
            : base(messageFormatter)
        {
        }
        public EmailAccountEventsHandler(IMessageFormatter<T> messageFormatter, IMessageDelivery messageDelivery)
            : base(messageFormatter, messageDelivery)
        {
        }

        public void Handle(AccountCreatedEvent evt)
        {
            Process(evt, new { evt.InitialPassword, evt.VerificationKey });
        }
        
        public void Handle(PasswordResetRequestedEvent<T> evt)
        {
            Process(evt, new { evt.VerificationKey });
        }

        public void Handle(PasswordChangedEvent evt)
        {
            Process(evt);
        }

        public void Handle(PasswordResetSecretAddedEvent evt)
        {
            Process(evt);
        }

        public void Handle(PasswordResetSecretRemovedEvent evt)
        {
            Process(evt);
        }
        
        public void Handle(UsernameReminderRequestedEvent<T> evt)
        {
            Process(evt);
        }

        public void Handle(AccountClosedEvent evt)
        {
            Process(evt);
        }
        
        public void Handle(AccountReopenedEvent evt)
        {
            Process(evt, new { evt.VerificationKey });
        }

        public void Handle(UsernameChangedEvent evt)
        {
            Process(evt);
        }

        public void Handle(EmailChangeRequestedEvent evt)
        {
            Process(evt, new{evt.OldEmail, evt.NewEmail, evt.VerificationKey});
        }

        public void Handle(EmailChangedEvent evt)
        {
            Process(evt, new { evt.OldEmail, evt.VerificationKey });
        }
        
        public void Handle(EmailVerifiedEvent evt)
        {
            Process(evt);
        }

        public void Handle(MobilePhoneChangedEvent evt)
        {
            Process(evt);
        }

        public void Handle(MobilePhoneRemovedEvent evt)
        {
            Process(evt);
        }

        public void Handle(CertificateAddedEvent evt)
        {
            Process(evt, new { evt.Certificate.Thumbprint, evt.Certificate.Subject });
        }

        public void Handle(CertificateRemovedEvent evt)
        {
            Process(evt, new { evt.Certificate.Thumbprint, evt.Certificate.Subject });
        }

        public void Handle(LinkedAccountAddedEvent evt)
        {
            Process(evt, new { evt.LinkedAccount.ProviderName });
        }

        public void Handle(LinkedAccountRemovedEvent evt)
        {
            Process(evt, new { evt.LinkedAccount.ProviderName });
        }
    }

    public class EmailAccountEventsHandler : EmailAccountEventsHandler<UserAccount>
    {
        public EmailAccountEventsHandler(IMessageFormatter<UserAccount> messageFormatter)
            : base(messageFormatter)
        {
        }
        public EmailAccountEventsHandler(IMessageFormatter<UserAccount> messageFormatter, IMessageDelivery messageDelivery)
            : base(messageFormatter, messageDelivery)
        {
        }
    }
}
