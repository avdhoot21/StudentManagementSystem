using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDetails
{
    public class StudentDataAccess
    {

        private static List<StudentModel> _students;
        
        /// <summary>
        /// Gets the Students
        /// </summary>
        /// <param name="SearchText">Search value</param>
        /// <returns>Return the matching students</returns>
        public void  GetStudents(StudentDTO studentDTO)
        {
            studentDTO.Students = new List<StudentModel>();
            if (_students == null)
            {
                InitializeStudentData();
            }

            studentDTO.Students = SearchData(studentDTO);
        }

        private void InitializeStudentData()
        {
                _students = new List<StudentModel>();
                _students.Add(new StudentModel
                {
                    StudentID = 1,
                    FirstName = "Neha",
                    LastName = "Gudil",
                    GenderID = 2,
                    Age = 21,
                    DateOfBirth = new DateTime(2001, 8, 9),
                    Class = "Class 1",
                    Address = "Kurla"
                });
                _students.Add(new StudentModel
                {
                    StudentID = 2,
                    FirstName = "Vivek",
                    LastName = "Mantri",
                    GenderID = 1,
                    Age = 24,
                    DateOfBirth = new DateTime(1998, 8, 5),
                    Class = "Class 3",
                    Address = "Dadar"
                });
        }

        private List<StudentModel> SearchData(StudentDTO studentDTO)
        {
            studentDTO.Students = new List<StudentModel>();
            studentDTO.SearchStudents = new string(studentDTO.SearchStudents);
            return _students.FindAll(Student => Student.FirstName.Contains(studentDTO.SearchStudents, StringComparison.CurrentCultureIgnoreCase) ||
              Student.LastName.Contains(studentDTO.SearchStudents, StringComparison.CurrentCultureIgnoreCase) ||
              Student.Age.ToString().Contains(studentDTO.SearchStudents, StringComparison.CurrentCultureIgnoreCase)).
                  Select(Student => new StudentModel
                  {
                      StudentID = Student.StudentID,
                      FirstName = Student.FirstName,
                      LastName = Student.LastName,
                      DateOfBirth = Student.DateOfBirth,
                      Age = Student.Age,
                      Gender = new GenderDataAccess().GenderText(Student.GenderID),
                      Class = Student.Class,
                      Address = Student.Address
                  }).ToList();
        }

        /// <summary>
        ///  Gets the Student Record 
        /// </summary>
        /// <param name="studentDTO">Uses StudentDTO to pass Student ID</param>
        public void GetStudent(StudentDTO studentDTO)
        {
            studentDTO.Genders = new List<GenderModel>();
            studentDTO.Student = _students.Find(Student => Student.StudentID == studentDTO.Student.StudentID);
            studentDTO.Genders = new GenderDataAccess().GetGenders();
        }

        /// <summary>
        /// Save Student Data 
        /// </summary>
        /// <param name="studentDTO">Uses StudentDTO to Save Student</param>
        public void SaveStudent(StudentDTO studentDTO)
        {
            if (studentDTO.Student.StudentID > 0)
            {
                foreach (StudentModel student in _students)
                {
                    if (student.StudentID == studentDTO.Student.StudentID)
                    {
                        student.FirstName = studentDTO.Student.FirstName;
                        student.LastName = studentDTO.Student.LastName;
                        student.Age = studentDTO.Student.Age;
                        student.GenderID = studentDTO.Student.GenderID;
                        student.DateOfBirth = studentDTO.Student.DateOfBirth;
                        student.Class = studentDTO.Student.Class;
                        student.Address = studentDTO.Student.Address;
                        break;
                    }
                }
            }
            else
            {
                studentDTO.Student.StudentID = _students.Count()>0 ? _students.Max(Student =>Student.StudentID )+1 : 1;
                _students.Add(studentDTO.Student);
            }
        }
        
        /// <summary>
        /// Deletes Student Record
        /// </summary>
        /// <param name="studentDTO">Uses StudentDTO to pass Student ID</param>
        public void DeleteStudent(StudentDTO studentDTO)
        {
          _students.RemoveAll(Student => Student.StudentID == studentDTO.Student.StudentID);
        }
    }
}















































