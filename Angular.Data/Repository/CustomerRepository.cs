using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angular.Core.IRepository.Base;
using Angular.Core.Modals;

namespace Angular.Data.Repository
{
    public class CustomerRepository
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerRepository(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
