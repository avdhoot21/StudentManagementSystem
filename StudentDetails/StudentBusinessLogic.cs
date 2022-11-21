namespace StudentDetails
{
    public class StudentBusinessLogic
    {
        /// <summary>
        /// Get the Students 
        /// </summary>
        /// <param name="SearchText">Search Value</param>
        /// <returns>Returns the Matching Students </returns>
        public void GetStudents(StudentDTO studentDTO)
        {
            new StudentDataAccess().GetStudents(studentDTO);
        }

        /// <summary>
        /// Deletes the Student Record 
        /// </summary>
        /// <param name="studentDTO">Uses StudentDTO to pass Student ID</param>
        public void DeleteStudent(StudentDTO studentDTO)
        {
            new StudentDataAccess().DeleteStudent(studentDTO);
        }

        /// <summary>
        /// Gets the Student Record  
        /// </summary>
        /// <param name="studentDTO">Uses StudentDTO to pass Student ID and return student record</param>
        public void GetStudent(StudentDTO studentDTO)
        {
            new StudentDataAccess().GetStudent(studentDTO);
        }

        /// <summary>
        /// Save Student Data
        /// </summary>
        /// <param name="studentDTO">Uses StudentDTO to Save Student</param>
        public void SaveStudent(StudentDTO studentDTO)
        {
             new StudentDataAccess().SaveStudent(studentDTO);
        }
    }
}















































































/// <returns>Return Student Record</returns>