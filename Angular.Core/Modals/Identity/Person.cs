using System;
using Angular.Core.Modals.Base;

namespace Angular.Core.Modals.Identity
{
    public class Person : Entity
    {
        public Person()
        {

            Id = Guid.NewGuid();

        }
        
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
