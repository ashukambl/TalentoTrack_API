﻿using SlackAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack_Common.DTOs.Account;

namespace TalentoTrack_Common.Services
{
    public interface IAccountServices
    {
        LoginResponse verifyLoginDetails(LoginRequest request);
    }
}
