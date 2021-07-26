using System.Collections.Generic;
using SchoolCycode.Models;
using SchoolCycode.Models.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace SchoolCycode.Data
{
    public class SqlStudentRepo : IStudentRepo
    {
        SchoolCycodeContext _context = new SchoolCycodeContext();

        public IEnumerable<Student> GetAppStudents()
        {
            var students = _context.Students.ToArray();
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
            var student = _context.Students.Find(id);

            if (student == null)
            {
                // Need to handle not exists student
                return new Student{Id=id, FirstName="Rea", LastName="Haas", Email="asdf"};
            }

            return student;

            // return new Student{Id=id, FirstName="Rea", LastName="Haas", Email="asdf"};
        }

        public async void InsertStudent(Student student)  // Task<ActionResult<Student>>
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetStudentById", new { id = student.Id }, student);
//            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }
    }
}