using System;

namespace Angular.Core.Modals
{
    public class UserClaim
    {
        public virtual Guid Id { get; set; }
        public virtual User User { get; set; }
        public virtual string ClaimType { get; set; }
        public virtual string ClaimValue { get; set; }
    }
}
