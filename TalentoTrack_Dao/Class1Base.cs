using Microsoft.EntityFrameworkCore;
using TalentoTrack_Dao.Entities;

namespace TalentoTrack_Dao
{
    public class Class1Base
    {
        public DbSet<User> tbl_user { get; set; }
    }
}