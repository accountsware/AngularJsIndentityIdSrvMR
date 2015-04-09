using System;

namespace AngularJs.Core.Modals
{
    public class UserRole
    {
        public virtual Guid RoleId { get; set; }

        public virtual Guid UserId { get; set; }

        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
}
