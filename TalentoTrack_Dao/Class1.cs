using Microsoft.EntityFrameworkCore;

using TalentoTrack_Dao.Entities;

namespace TalentoTrack_Dao
{
    public class Class1
    {
        public required DbSet<User> tbl_user { get; set; }

       
    }
}