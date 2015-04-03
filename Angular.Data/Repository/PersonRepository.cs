using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angular.Data.IRepository;
using Angular.Data.Modals;
using Angular.Data.Repository.@base;

namespace Angular.Data.Repository
{
    public class PersonRepository: GenericRepository<Person>,IPersonRepository
    {
        public PersonRepository(DataContext context) : base(context)
        {
        }
    }
}
