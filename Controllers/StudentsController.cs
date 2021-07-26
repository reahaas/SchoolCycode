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
        public ActionResult PostStudent(Student student)
        {

            ((IStudentRepo)_repository).InsertStudent(student);
//            var insert_results = {"status": 200};
            return Ok(200);
            //            _context.Students.Add(student);
            //            await _context.SaveChangesAsync();
            //
            //            //return CreatedAtAction("GetStudentById", new { id = student.Id }, student);
            //            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }
    }
}