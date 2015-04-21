using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Angular.Core.Modals.Base;

namespace Angular.Core.Modals.Identity
{
    public class UserAccount: Entity

    {
        public UserAccount()
        {
       

        }

        #region Properties
        public virtual Guid ID { get; set; }

        public virtual string Tenant { get; set; }

        // If email address is being used as the username then this property
        // should adhere to maximim length constraint for valid email addresses.
        // See Dominic Sayers answer at SO: http://stackoverflow.com/a/574698/99240
        [StringLength(254)]
        [Required]
        public virtual string Username { get; set; }

        public virtual DateTime Created { get; set; }
        public virtual DateTime LastUpdated { get; set; }
        public virtual bool IsAccountClosed { get; set; }
        public virtual DateTime? AccountClosed { get; set; }

        public virtual bool IsLoginAllowed { get; set; }
        public virtual DateTime? LastLogin { get; set; }
        public virtual DateTime? LastFailedLogin { get; set; }
        public virtual int FailedLoginCount { get; set; }

        public virtual DateTime? PasswordChanged { get; set; }
        public virtual bool RequiresPasswordReset { get; set; }

        // Maximum length of a valid email address is 254 characters.
        // See Dominic Sayers answer at SO: http://stackoverflow.com/a/574698/99240
        [EmailAddress]
        [StringLength(254)]
        public virtual string Email { get; set; }
        public virtual bool IsAccountVerified { get; set; }

        public virtual DateTime? LastFailedPasswordReset { get; set; }
        public virtual int FailedPasswordResetCount { get; set; }

        [StringLength(100)]
        public virtual string MobileCode { get; set; }
        public virtual DateTime? MobileCodeSent { get; set; }
        [StringLength(20)]
        public virtual string MobilePhoneNumber { get; set; }
        public virtual DateTime? MobilePhoneNumberChanged { get; set; }

        public virtual TwoFactorAuthMode AccountTwoFactorAuthMode { get; set; }
        public virtual TwoFactorAuthMode CurrentTwoFactorAuthStatus { get; set; }

        [StringLength(100)]
        public virtual string VerificationKey { get; set; }
        public virtual VerificationKeyPurpose? VerificationPurpose { get; set; }
        public virtual DateTime? VerificationKeySent { get; set; }
        [StringLength(100)]
        public virtual string VerificationStorage { get; set; }

        [StringLength(200)]
        public virtual string HashedPassword { get; set; }

        #endregion Properties

        public virtual ICollection<UserClaim> ClaimCollection { get; set; }
        public  IEnumerable<UserClaim> Claims
        {
            get { return ClaimCollection; }
        }
        public  void AddClaim(UserClaim item)
        {
            ClaimCollection.Add(new UserClaim {  Type = item.Type, Value = item.Value, UserId = this.ID});
        }
        public  void RemoveClaim(UserClaim item)
        {
            ClaimCollection.Remove((UserClaim)item);
        }

        public virtual ICollection<LinkedAccount> LinkedAccountCollection { get; set; }
        public  IEnumerable<LinkedAccount> LinkedAccounts
        {
            get { return LinkedAccountCollection; }
        }
        public  void AddLinkedAccount(LinkedAccount item)
        {
            LinkedAccountCollection.Add(new LinkedAccount { ProviderName = item.ProviderName, ProviderAccountID = item.ProviderAccountID, LastLogin = item.LastLogin, UserId  = this.ID});
        }
        public  void RemoveLinkedAccount(LinkedAccount item)
        {
            LinkedAccountCollection.Remove((LinkedAccount)item);
        }

        public virtual ICollection<LinkedAccountClaim> LinkedAccountClaimCollection { get; set; }
        public  IEnumerable<LinkedAccountClaim> LinkedAccountClaims
        {
            get { return LinkedAccountClaimCollection; }
        }
        public  void AddLinkedAccountClaim(LinkedAccountClaim item)
        {
            LinkedAccountClaimCollection.Add(new LinkedAccountClaim {  ProviderName = item.ProviderName, ProviderAccountID = item.ProviderAccountID, Type = item.Type, Value = item.Value, UserId = this.ID});
        }
        public  void RemoveLinkedAccountClaim(LinkedAccountClaim item)
        {
            LinkedAccountClaimCollection.Remove((LinkedAccountClaim)item);
        }

        public virtual ICollection<UserCertificate> UserCertificateCollection { get; set; }
        public  IEnumerable<UserCertificate> Certificates
        {
            get { return UserCertificateCollection; }
        }
        public  void AddCertificate(UserCertificate item)
        {
            UserCertificateCollection.Add(new UserCertificate { Thumbprint = item.Thumbprint, Subject = item.Subject, UserId = this.ID});
        }
        public  void RemoveCertificate(UserCertificate item)
        {
            UserCertificateCollection.Remove((UserCertificate)item);
        }

        public virtual ICollection<TwoFactorAuthToken> TwoFactorAuthTokenCollection { get; set; }
        public  IEnumerable<TwoFactorAuthToken> TwoFactorAuthTokens
        {
            get { return TwoFactorAuthTokenCollection; }
        }

        public void AddTwoFactorAuthToken(TwoFactorAuthToken item)
        {
            TwoFactorAuthTokenCollection.Add(new TwoFactorAuthToken { Token = item.Token, Issued = item.Issued, UserId = this.ID});
        }
        public void RemoveTwoFactorAuthToken(TwoFactorAuthToken item)
        {
            TwoFactorAuthTokenCollection.Remove((TwoFactorAuthToken)item);
        }

        public virtual ICollection<PasswordResetSecret> PasswordResetSecretCollection { get; set; }
        public  IEnumerable<PasswordResetSecret> PasswordResetSecrets
        {
            get { return PasswordResetSecretCollection; }
        }
        public  void AddPasswordResetSecret(PasswordResetSecret item)
        {
            PasswordResetSecretCollection.Add(new PasswordResetSecret { PasswordResetSecretID = item.PasswordResetSecretID, Question = item.Question, Answer = item.Answer, UserId = this.ID});
        }
        public void RemovePasswordResetSecret(PasswordResetSecret item)
        {
            PasswordResetSecretCollection.Remove((PasswordResetSecret)item);
        }
    }
}
