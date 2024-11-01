using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsAPI.DataSimulation;
using StudentsAPI.Model;

namespace StudentsAPI.Controllers
{
    [Route("api/Students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllStudents")]
        public ActionResult<IEnumerable<Student>> GetAllStudents ()
        {
            return Ok(StudentsDataSimulation.StudentsList);
        }

        [HttpGet("{id}")]
        public ActionResult<Student> GetStudentById(int StudentID)
        {
            foreach (Student item in StudentsDataSimulation.StudentsList)
            {
                if (item.ID == StudentID)
                {
                    return Ok(item);
                }
            }
            return null;
        }

        [HttpGet("Passed", Name = "GetPassedStudents")]
        public ActionResult<IEnumerable<Student>> GetPassedStudents()
        {
            var PassedStudents = StudentsDataSimulation.StudentsList.Where(student => student.Grade >= 50).ToList();
            return Ok(PassedStudents);
        }
    }
}
