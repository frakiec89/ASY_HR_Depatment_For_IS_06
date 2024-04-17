// track
using Microsoft.EntityFrameworkCore;

namespace ASY_HR_Depatment.DB
{
    public class MS_Context : DbContext
    {
        private string _cs =
            "server=192.168.59.63 ; database=ASY_HR_Athyamov;user id=stud;" +
            "password=stud;TrustServerCertificate=true;";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_cs);
        }


        public DbSet<User> Users { get; set; }


    }
}
