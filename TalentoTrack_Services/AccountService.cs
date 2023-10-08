using SlackAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack_Common.DTOs.Account;
using TalentoTrack_Common.Services;

namespace TalentoTrack_Services
{
    public class AccountService : IAccountServices
    {
       public async Task<LoginResponse> verifyLoginDetails(LoginRequest request)//async is improve the api perfromance every business logic will be perform in child thread and main thread will be free for service some additional records
        {
            LoginResponse response = new LoginResponse();
            try
            { 
            }
            catch (Exception ex)
            {

            }
        }
    }
}
