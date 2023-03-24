using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT_Basic_Implementation.DTO;
using JWT_Basic_Implementation.SERVICES;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT_Basic_Implementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private AuthorizationService service = new AuthorizationService();
        [HttpPost]
        public string PostUserName([FromBody] UserDTO credentials)
        {
            if (credentials.email == "" || credentials.password == "")
            {
                return "User or password not loaded";
                
            }
            else if(credentials != null)
            {
                return service.GetUserAuthentication(credentials);
            }
            else
            {
                return "error on api";
            }
        }
    }
}
