using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Angular.Data.Modals
{
    public class Role : IRole<Guid>
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
