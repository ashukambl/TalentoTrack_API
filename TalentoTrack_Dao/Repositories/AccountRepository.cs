using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack_Common.DTOs.Account;
using TalentoTrack_Common.Entities;
using TalentoTrack_Dao.DB;

namespace TalentoTrack_Dao.Repositories
{
    public class AccountRepository
    {
        public TalentoTrack_DbContext _dbContext;

        public AccountRepository(TalentoTrack_DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<LoginDetails> GetLoginDetails(LoginRequest request)//here GetLoginDetails by using the usename and pwd from the db
        {
            var dbRecord = await _dbContext.tbl_login_details.Where(p => (p.UserName != null && p.UserName.Equals(request.Username)) && (p.Password != null && p.Password.Equals(request.Password))).FirstOrDefaultAsync();
            //await keyword write here bcoz this fun is async if it is async we have to use await key somewhere

            return dbRecord!;// this fun is just get the logindetails from the db with provided credentials 
            {
            }
        }
    

