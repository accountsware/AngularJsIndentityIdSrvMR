
using System.Web.Http;

using Angular.Data.Modals;


namespace Angular.Api.Controllers
{
    [RoutePrefix("api/person")]
    public class PersonController : ApiController
    {
     


        public PersonController()
        {


        }
         [Route("Add")]
        public IHttpActionResult Add(Person prson)
        {


            


            return Ok();



        }

    }
}
