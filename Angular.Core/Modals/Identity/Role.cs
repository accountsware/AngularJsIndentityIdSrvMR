using System;
using System.Collections.Generic;
using Angular.Core.Modals.Identity;

namespace Angular.Core.Modals
{
    public class Role// : IRole<Guid>
    {

        public Role(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual IList<UserRole> Users { get; set; }

    }
}
