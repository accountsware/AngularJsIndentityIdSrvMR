using System;

namespace Angular.Core.Modals.Identity
{
    public class UserRole
    {
        public virtual Guid RoleId { get; set; }

        public virtual Guid UserId { get; set; }

        public virtual UserAccount User { get; set; }

        public virtual Role Role { get; set; }
    }
}
