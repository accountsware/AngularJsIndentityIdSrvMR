using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Angular.Common;
using Angular.Data;
using Angular.Data.IRepository;


namespace Angular.Api.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {


        



        public UserController()
        {
            
        }


        [Route("Name")]
        [HttpGet]
        public string Name()
        {
            return "Whats up";
        }
        [Route("Text")]
        [HttpGet]
        public IHttpActionResult Text()
        {

            return Ok("Hello from HTTP");
        }

        [Route("Register")]
        public IHttpActionResult Register(CreateUserBindingModel usr)
        {

           
                return Ok();   
            

          
        }
    }
}
