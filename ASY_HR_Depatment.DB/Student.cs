// track
namespace ASY_HR_Depatment.DB
{
    public class Student
    {

        public int StudentID { get; set; }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Patronumic {  get; set; }

        public int GroupID { get; set; }

        public Group Group { get; set; } // навигация 


    }
}