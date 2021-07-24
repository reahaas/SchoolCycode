using System.Collections.Generic;
using SchoolCycode.Models;
using SchoolCycode.Models.PostgreSQL;


namespace SchoolCycode.Data
{
    public class SqlStudentRepo : IStudentRepo
    {
        var _context = new SchoolCycodeContext()

        public IEnumerable<Student> GetAppStudents()
        {
            var students = _context.Students.ToArray()
//            new List<Student>
//            {
//                new Student{Id= 1, FirstName="Rea1", LastName="Haas1", Email="Rea1@asdf.com"},
//                new Student{Id=2, FirstName="Rea2", LastName="Haas2", Email="Rea2@asdf.com"},
//                new Student{Id=3, FirstName="Rea3", LastName="Haas3", Email="Rea3@asdf.com"}
//            };
            return students;
        }

        public Student GetStudentById(int id)
        {
            return new Student{Id=id, FirstName="Rea", LastName="Haas", Email="asdf"};
        }

        public InsertStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetStudentById", new { id = student.Id }, student);
            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }
    }
}