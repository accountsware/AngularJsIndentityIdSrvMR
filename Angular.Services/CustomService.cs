using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angular.Core.IRepository.Base;
using Angular.Core.IServices;
using Angular.Core.Modals;
using Angular.Core.Modals.CustomerOrder;
using Angular.Services.Base;

namespace Angular.Services
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        private readonly IRepositoryAsync<Customer> _repository;

        public CustomerService(IRepositoryAsync<Customer> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
