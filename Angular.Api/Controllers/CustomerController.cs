using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Angular.Core.IRepository.Base;
using Angular.Core.IServices;
using Angular.Core.Modals;

namespace Angular.Api.Controllers
{
    [RoutePrefix("api/customer")]
    public class CustomerController : ApiController
    {
        private readonly ICustomerService _customerService;
      //  private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public CustomerController(
            IUnitOfWorkAsync unitOfWorkAsync,
            ICustomerService customerService)
        {
       //     _unitOfWorkAsync = unitOfWorkAsync;
            _customerService = customerService;
        }
        [Route("GetAll")]
        [HttpGet]
        
        public IQueryable<Customer> GetCustomers()
        {
            return _customerService.Queryable();
        }

    }
}
