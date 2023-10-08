﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack_Common.Entities;
using TalentoTrack_Dao.Entities;
    
namespace TalentoTrack_Dao.DB
{
    public class TalentoTrack_DbContext : DbContext
    {
        public DbSet<User> tbl_user { get; set; }

        public DbSet<LoginDetails> tbl_login_details {  get; set; } 

        public TalentoTrack_DbContext(DbContextOptions<TalentoTrack_DbContext> options) : base(options) { }

       
    }
}
