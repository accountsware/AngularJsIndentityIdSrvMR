using System;

namespace AngularJs.Core.Modals
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