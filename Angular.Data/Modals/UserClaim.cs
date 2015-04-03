using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Angular.Data.Modals
{
    public class UserClaim
    {
        public virtual Guid Id { get; set; }
        public virtual User User { get; set; }
        public virtual string ClaimType { get; set; }
        public virtual string ClaimValue { get; set; }
    }
}
