using System.Collections.Generic;
// using SchoolCycode.Models;

namespace SchoolCycode.Data
{
    public interface IStudentRepo
    {
        IEnumerable<Models.Student> GetAppStudents();
        Models.Student GetStudentById(int id);
        InsertStudent(Student student)
    }
}