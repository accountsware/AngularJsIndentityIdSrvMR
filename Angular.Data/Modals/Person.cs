using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Data.Modals
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
