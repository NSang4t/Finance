using Finance.Interface;
using Finance.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentModelController : ControllerBase
    {
        private readonly IStudentModel _student;
        private readonly DataContext _context;
        public StudentModelController(IStudentModel student, DataContext context)
        {
            _context = context;
            _student = student;
        }

      
        [HttpGet]
        [Route("list-student")]
        public async Task<ActionResult<IEnumerable<StudentModel>>> GetAllStudent()
        {

            return await _student.GetAllStudent(); ;
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, StudentModel student)
        {
            if (id != student.Id_Student)
            {
                return BadRequest();
            }


            if (!ModelState.IsValid)
                return BadRequest(ModelState);




            try
            {
                await _student.EditStudent(id, student);

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(new
            {
                //_NguoiDung.GetNguoidungAsync(id),
                retCode = 0,
                retText = "Update thành công"
            });

        }
        private bool UserModelExists(int id)
        {
            return _context.UserModels.Any(e => e.User_ID == id);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student  = await _context.StudentModels.FindAsync(id);
            if (student == null)
            {
                return NotFound();

            }


            _context.StudentModels.Remove(student);
            await _context.SaveChangesAsync();

            return Ok();
        }

      
    }
}
