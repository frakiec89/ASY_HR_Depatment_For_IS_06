// track
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ASY_HR_Depatment.DB
{

    [Index(nameof(Name), IsUnique = true)]
    public class Group
    {
        [Key]
        public int GroupID { get; set; }

        [Required]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
