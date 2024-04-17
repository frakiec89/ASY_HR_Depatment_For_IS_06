// track

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ASY_HR_Depatment.DB
{

    [Index(nameof(Login), IsUnique = true)]
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string UserName { get; set; }
       
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
