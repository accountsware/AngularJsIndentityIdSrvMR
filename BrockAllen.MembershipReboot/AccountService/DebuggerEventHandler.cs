/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */

using System.Diagnostics;
using Angular.Core.Modals.Identity;

namespace BrockAllen.MembershipReboot
{
    public class DebuggerEventHandler<TAccount> : 
        IEventHandler<AccountCreatedEvent>,
        IEventHandler<PasswordResetRequestedEvent<TAccount>>,
        IEventHandler<EmailChangeRequestedEvent>,
        IEventHandler<EmailChangedEvent>,
        IEventHandler<MobilePhoneChangeRequestedEvent>,
        IEventHandler<TwoFactorAuthenticationCodeNotificationEvent<TAccount>>
    {
        public void Handle(AccountCreatedEvent evt)
        {
            Debug.WriteLine("AccountCreatedEvent: " + evt.VerificationKey);
        }

        public void Handle(PasswordResetRequestedEvent<TAccount> evt)
        {
            Debug.WriteLine("PasswordResetRequestedEvent: " + evt.VerificationKey);
        }

        public void Handle(EmailChangeRequestedEvent evt)
        {
            Debug.WriteLine("EmailChangeRequestedEvent: " + evt.VerificationKey);
        }

        public void Handle(EmailChangedEvent evt)
        {
            Debug.WriteLine("EmailChangedEvent: " + evt.VerificationKey);
        }

        public void Handle(MobilePhoneChangeRequestedEvent evt)
        {
            Debug.WriteLine("MobilePhoneChangeRequestedEvent: " + evt.Code);
        }

        public void Handle(TwoFactorAuthenticationCodeNotificationEvent<TAccount> evt)
        {
            Debug.WriteLine("TwoFactorAuthenticationCodeNotificationEvent: " + evt.Code);
        }
    }

    public class DebuggerEventHandler : DebuggerEventHandler<UserAccount> { }
}
