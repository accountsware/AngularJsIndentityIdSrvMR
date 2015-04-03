using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Angular.Data.Modals
{
    public class UserLogin
    {
        public UserLogin()
        {

        }

        public virtual string LoginProvider { get; set; }
        public virtual string ProviderKey { get; set; }
        public virtual Guid UserId { get; set; }
    }
}