using System;
using System.Collections.Generic;

namespace Angular.Core.Modals
{
    public class User //: IUser<Guid>
    {
        public User()
        {
            //this.Person = new Person();
            Id = Guid.NewGuid();
            this.Claims = new List<UserClaim>();
            this.Logins = new List<UserLogin>();
            this.Roles = new List<UserRole>();
        }





        #region IdentityUserFields

        public virtual int AccessFailedCount { get; set; }

        public virtual IList<UserClaim> Claims { get; set; }

        public virtual string Email { get; set; }

        public virtual bool EmailConfirmed { get; set; }

        public virtual bool LockoutEnabled { get; set; }

        public virtual DateTime? LockoutEndDateUtc { get; set; }

        public virtual IList<UserLogin> Logins { get; set; }

        public virtual string PasswordHash { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual bool PhoneNumberConfirmed { get; set; }

        public virtual IList<UserRole> Roles { get; set; }

        public virtual string SecurityStamp { get; set; }

        public virtual bool TwoFactorEnabled { get; set; }

        public Guid Id { get; set; }
        public virtual string UserName { get; set; }

        #endregion
    }
}
