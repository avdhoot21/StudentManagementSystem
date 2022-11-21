using System.Collections.Generic;

namespace StudentDetails
{
    public class StudentDTO
    {
        public List<StudentModel> Students { get; set; }
        public StudentModel Student { get; set; }
        public List<GenderModel> Genders { get; set; }
        public string SearchStudents { get; set; } = "";
    }
}
