using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Angular.Common;
using Angular.Data.IServices;



namespace Angular.Api.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private IUserService _userService;


        public UserController()
        {
            
        }
        public UserController(IUserService userService)
        {
            _userService = userService;

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
           


              _userService.RegisterUser(usr);

   
           
                return Ok();   
            

          
        }
    }
}
