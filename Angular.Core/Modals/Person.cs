using System;

namespace Angular.Core.Modals
{
    public class Person
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
