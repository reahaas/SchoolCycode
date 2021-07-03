using System.Collections.Generic;
using SchoolCycode.Models;

namespace SchoolCycode.Data
{
    public class MockStudentRepo : IStudentRepo
    {
        public IEnumerable<Student> GetAppStudents()
        {
            var students = new List<Student>
            {
                new Student{Id= 1, FirstName="Rea1", LastName="Haas1", Email="Rea1@asdf.com"},
                new Student{Id=2, FirstName="Rea2", LastName="Haas2", Email="Rea2@asdf.com"},
                new Student{Id=3, FirstName="Rea3", LastName="Haas3", Email="Rea3@asdf.com"}    
            };
            return students;
        }

        public Student GetStudentById(int id)
        {
            return new Student{Id=id, FirstName="Rea", LastName="Haas", Email="asdf"};
        }
    }
}