
using System.Web.Http;
using Angular.Data.IServices;
using Angular.Data.Modals;
using Angular.Data.Repository.@base;

namespace Angular.Api.Controllers
{
    [RoutePrefix("api/person")]
    public class PersonController : ApiController
    {
        private IPersonService _personService;

        public PersonController()
        {
           
        }
        public PersonController(IPersonService personService)
        {
            _personService = personService;

        }
         [Route("Add")]
        public IHttpActionResult Add(Person prson)
        {

            _personService.AddPerson(prson);
            


            return Ok();



        }

    }
}
