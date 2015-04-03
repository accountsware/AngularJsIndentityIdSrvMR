using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Angular.Data.Modals
{
    public class UserRole
    {
        public virtual Guid RoleId { get; set; }

        public virtual Guid UserId { get; set; }

        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
}
