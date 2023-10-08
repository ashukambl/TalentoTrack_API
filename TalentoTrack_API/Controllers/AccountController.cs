using Microsoft.AspNetCore.Mvc;
using TalentoTrack.API.Controllers;
using TalentoTrack_Common.DTOs.Account;

namespace TalentoTrack_API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]//Route means our controller name 
    public class AccountController : ControllerBase
    {
      
      
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Login")]
        public LoginResponse Login([FromBody]LoginRequest request)
        {
           var response= new LoginResponse();
            if(request.Username=="admin" && request.Password=="123") 
            { 
                response.Success = true;
            }
            else
            {
                response.Success = false;
                response.ErrorMessage = "Invalid credentials";
            }
            return response;
        }
    }
}