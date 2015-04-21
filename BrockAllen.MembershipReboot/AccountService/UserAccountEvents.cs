/*
 * Copyright (c) Brock Allen.  All rights reserved.
 * see license.txt
 */


using System.Security.Cryptography.X509Certificates;
using Angular.Core.Modals.Identity;

namespace BrockAllen.MembershipReboot
{
    interface IAllowMultiple { }

    public abstract class UserAccountEvent : IEvent
    {
        //public UserAccountService<T> UserAccountService { get; set; }
        public UserAccount Account { get; set; }
    }

    public class AccountCreatedEvent : UserAccountEvent
    {
        // InitialPassword might be null if this is a re-send
        // notification for account created (when user tries to
        // reset password before verifying their account)
        public string InitialPassword { get; set; }
        public string VerificationKey { get; set; }
    }

    public class PasswordResetFailedEvent : UserAccountEvent { }
    public class PasswordResetRequestedEvent<T> : UserAccountEvent
    {
        public string VerificationKey { get; set; }
    }
    public class PasswordChangedEvent : UserAccountEvent
    {
        public string NewPassword { get; set; }
    }
    public class PasswordResetSecretAddedEvent : UserAccountEvent
    {
        public PasswordResetSecret Secret { get; set; }
    }
    public class PasswordResetSecretRemovedEvent : UserAccountEvent
    {
        public PasswordResetSecret Secret { get; set; }
    }
    
    public class CertificateAddedEvent : UserAccountEvent, IAllowMultiple
    {
        public UserCertificate Certificate { get; set; }
    }
    public class CertificateRemovedEvent : UserAccountEvent, IAllowMultiple
    {
        public UserCertificate Certificate { get; set; }
    }

    public class UsernameReminderRequestedEvent<T> : UserAccountEvent { }
    public class AccountClosedEvent : UserAccountEvent { }
    public class AccountReopenedEvent : UserAccountEvent
    {
        public string VerificationKey { get; set; }
    }
    public class UsernameChangedEvent : UserAccountEvent { }
    
    public class EmailChangeRequestedEvent : UserAccountEvent
    {
        public string OldEmail { get; set; }
        public string NewEmail { get; set; }
        public string VerificationKey { get; set; }
    }
    public class EmailChangedEvent : UserAccountEvent
    {
        public string OldEmail { get; set; }
        public string VerificationKey { get; set; }
    }
    public class EmailVerifiedEvent : UserAccountEvent { }

    public class MobilePhoneChangeRequestedEvent : UserAccountEvent
    {
        public string NewMobilePhoneNumber { get; set; }
        public string Code { get; set; }
    }
    public class MobilePhoneChangedEvent : UserAccountEvent { }
    public class MobilePhoneRemovedEvent : UserAccountEvent { }

    public class TwoFactorAuthenticationEnabledEvent : UserAccountEvent
    {
        public TwoFactorAuthMode Mode { get; set; }
    }
    public class TwoFactorAuthenticationDisabledEvent : UserAccountEvent { }

    public class TwoFactorAuthenticationCodeNotificationEvent<T> : UserAccountEvent
    {
        public string Code { get; set; }
    }
    public class TwoFactorAuthenticationTokenCreatedEvent : UserAccountEvent
    {
        public string Token { get; set; }
    }

    public class ClaimAddedEvent : UserAccountEvent, IAllowMultiple
    {
        public UserClaim Claim { get; set; }
    }
    public class ClaimRemovedEvent : UserAccountEvent, IAllowMultiple
    {
        public UserClaim Claim { get; set; }
    }

    public class LinkedAccountAddedEvent : UserAccountEvent, IAllowMultiple
    {
        public LinkedAccount LinkedAccount { get; set; }
    }
    public class LinkedAccountRemovedEvent : UserAccountEvent, IAllowMultiple
    {
        public LinkedAccount LinkedAccount { get; set; }
    }

    public abstract class SuccessfulLoginEvent : UserAccountEvent { }
    public class SuccessfulPasswordLoginEvent : SuccessfulLoginEvent { }
    public class SuccessfulCertificateLoginEvent : SuccessfulLoginEvent
    {
        public UserCertificate UserCertificate { get; set; }
        public X509Certificate2 Certificate { get; set; }
    }
    public class SuccessfulTwoFactorAuthCodeLoginEvent : SuccessfulLoginEvent { }

    public abstract class FailedLoginEvent : UserAccountEvent { }
    public class AccountNotVerifiedEvent : FailedLoginEvent { }
    public class AccountLockedEvent : FailedLoginEvent { }
    public class InvalidAccountEvent : FailedLoginEvent { }
    public class TooManyRecentPasswordFailuresEvent : FailedLoginEvent { }
    public class InvalidPasswordEvent : FailedLoginEvent { }
    public class InvalidCertificateEvent : FailedLoginEvent
    {
        public X509Certificate2 Certificate { get; set; }
    }
}
