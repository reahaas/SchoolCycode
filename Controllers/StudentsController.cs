using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SchoolCycode.Data;
using SchoolCycode.Models;

namespace SchoolCycode.Controllers
{
    // api/students
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepo _repository = new MockStudentRepo();
        public StudentsController(IStudentRepo repository)
        {
            _repository = (MockStudentRepo)repository;
        }

        [HttpGet]
        public ActionResult <IEnumerable<Student>> GetAllStudents()
        {
            var studentItems = ((IStudentRepo)_repository).GetAppStudents();
            return Ok(studentItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Student> GetStudentById(int id)
        {
            var studentItem = ((IStudentRepo)_repository).GetStudentById(id);
            return Ok(studentItem);
        }
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetStudentById", new { id = student.Id }, student);
            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }
    }
}