using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Angular.Core.Modals.Identity
{
    public class UserAccount
    {
        public virtual Guid ID { get; protected internal set; }


        public virtual string Tenant { get; protected internal set; }

        // If email address is being used as the username then this property
        // should adhere to maximim length constraint for valid email addresses.
        // See Dominic Sayers answer at SO: http://stackoverflow.com/a/574698/99240
        [StringLength(254)]
        [Required]
        public virtual string Username { get; protected internal set; }

        public virtual DateTime Created { get; protected internal set; }
        public virtual DateTime LastUpdated { get; protected internal set; }
        public virtual bool IsAccountClosed { get; protected internal set; }
        public virtual DateTime? AccountClosed { get; protected internal set; }

        public virtual bool IsLoginAllowed { get; protected internal set; }
        public virtual DateTime? LastLogin { get; protected internal set; }
        public virtual DateTime? LastFailedLogin { get; protected internal set; }
        public virtual int FailedLoginCount { get; protected internal set; }

        public virtual DateTime? PasswordChanged { get; protected internal set; }
        public virtual bool RequiresPasswordReset { get; protected internal set; }

        // Maximum length of a valid email address is 254 characters.
        // See Dominic Sayers answer at SO: http://stackoverflow.com/a/574698/99240
        [EmailAddress]
        [StringLength(254)]
        public virtual string Email { get; protected internal set; }
        public virtual bool IsAccountVerified { get; protected internal set; }

        public virtual DateTime? LastFailedPasswordReset { get; protected internal set; }
        public virtual int FailedPasswordResetCount { get; protected internal set; }

        [StringLength(100)]
        public virtual string MobileCode { get; protected internal set; }
        public virtual DateTime? MobileCodeSent { get; protected internal set; }
        [StringLength(20)]
        public virtual string MobilePhoneNumber { get; protected internal set; }
        public virtual DateTime? MobilePhoneNumberChanged { get; protected internal set; }

        public virtual TwoFactorAuthMode AccountTwoFactorAuthMode { get; protected internal set; }
        public virtual TwoFactorAuthMode CurrentTwoFactorAuthStatus { get; protected internal set; }

        [StringLength(100)]
        public virtual string VerificationKey { get; protected internal set; }
        public virtual VerificationKeyPurpose? VerificationPurpose { get; protected internal set; }
        public virtual DateTime? VerificationKeySent { get; protected internal set; }
        [StringLength(100)]
        public virtual string VerificationStorage { get; protected internal set; }

        [StringLength(200)]
        public virtual string HashedPassword { get; protected internal set; }

        public virtual ICollection<UserClaim> ClaimCollection { get; set; }
        public  IEnumerable<UserClaim> Claims
        {
            get { return ClaimCollection; }
        }
        protected internal  void AddClaim(UserClaim item)
        {
            ClaimCollection.Add(new UserClaim { Type = item.Type, Value = item.Value });
        }
        protected internal  void RemoveClaim(UserClaim item)
        {
            ClaimCollection.Remove((UserClaim)item);
        }

        public virtual ICollection<LinkedAccount> LinkedAccountCollection { get; set; }
        public  IEnumerable<LinkedAccount> LinkedAccounts
        {
            get { return LinkedAccountCollection; }
        }
        protected internal  void AddLinkedAccount(LinkedAccount item)
        {
            LinkedAccountCollection.Add(new LinkedAccount { ProviderName = item.ProviderName, ProviderAccountID = item.ProviderAccountID, LastLogin = item.LastLogin });
        }
        protected internal  void RemoveLinkedAccount(LinkedAccount item)
        {
            LinkedAccountCollection.Remove((LinkedAccount)item);
        }

        public virtual ICollection<LinkedAccountClaim> LinkedAccountClaimCollection { get; set; }
        public  IEnumerable<LinkedAccountClaim> LinkedAccountClaims
        {
            get { return LinkedAccountClaimCollection; }
        }
        protected internal  void AddLinkedAccountClaim(LinkedAccountClaim item)
        {
            LinkedAccountClaimCollection.Add(new LinkedAccountClaim {  ProviderName = item.ProviderName, ProviderAccountID = item.ProviderAccountID, Type = item.Type, Value = item.Value });
        }
        protected internal  void RemoveLinkedAccountClaim(LinkedAccountClaim item)
        {
            LinkedAccountClaimCollection.Remove((LinkedAccountClaim)item);
        }

        public virtual ICollection<UserCertificate> UserCertificateCollection { get; set; }
        public  IEnumerable<UserCertificate> Certificates
        {
            get { return UserCertificateCollection; }
        }
        protected internal  void AddCertificate(UserCertificate item)
        {
            UserCertificateCollection.Add(new UserCertificate { Thumbprint = item.Thumbprint, Subject = item.Subject });
        }
        protected internal  void RemoveCertificate(UserCertificate item)
        {
            UserCertificateCollection.Remove((UserCertificate)item);
        }

        public virtual ICollection<TwoFactorAuthToken> TwoFactorAuthTokenCollection { get; set; }
        public  IEnumerable<TwoFactorAuthToken> TwoFactorAuthTokens
        {
            get { return TwoFactorAuthTokenCollection; }
        }

        protected internal void AddTwoFactorAuthToken(TwoFactorAuthToken item)
        {
            TwoFactorAuthTokenCollection.Add(new TwoFactorAuthToken { Token = item.Token, Issued = item.Issued });
        }
        protected internal void RemoveTwoFactorAuthToken(TwoFactorAuthToken item)
        {
            TwoFactorAuthTokenCollection.Remove((TwoFactorAuthToken)item);
        }

        public virtual ICollection<PasswordResetSecret> PasswordResetSecretCollection { get; set; }
        public  IEnumerable<PasswordResetSecret> PasswordResetSecrets
        {
            get { return PasswordResetSecretCollection; }
        }
        protected internal  void AddPasswordResetSecret(PasswordResetSecret item)
        {
            PasswordResetSecretCollection.Add(new PasswordResetSecret { PasswordResetSecretID = item.PasswordResetSecretID, Question = item.Question, Answer = item.Answer });
        }
        protected internal void RemovePasswordResetSecret(PasswordResetSecret item)
        {
            PasswordResetSecretCollection.Remove((PasswordResetSecret)item);
        }
    }
}
