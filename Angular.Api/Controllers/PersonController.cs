
using System.Web.Http;


namespace Angular.Api.Controllers
{
    [RoutePrefix("api/person")]
    public class PersonController : ApiController
    {
     


        public PersonController()
        {


        }
         [Route("Add")]
        public IHttpActionResult Add()
        {


            


            return Ok();



        }

    }
}
