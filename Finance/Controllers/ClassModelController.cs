using Finance.Interface;
using Finance.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClassModelController : ControllerBase
    {
        private readonly ICLassModel _classmodel;
        public ClassModelController(ICLassModel classmodel)
        {
            _classmodel = classmodel;
        }
        [HttpGet]
        [ActionName("get")]
        public async Task<ActionResult<IEnumerable<ClassModel>>> GetCkassAll()
        {
            var list = await _classmodel.GetAllClass();
            return list;
        }

        [HttpPost]
      
        [ActionName("create")]
        public async Task<ActionResult> AddClass(ClassModel classmodel)
        {
            try
            {
                    await _classmodel.AddClass(classmodel);
                return Ok("Thêm thành công");
               
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok("Lượm ");
        }

        [HttpPost]
        [ActionName("update")]
        public async Task<ActionResult> UpdateClass(int id, ClassModel lophoc)
        {
            try
            {
                await _classmodel.EditClass(id, lophoc);
                lophoc.Id_Class = id;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(1);
        }

        [HttpDelete("{id}")]
        [ActionName("delete")]
        public async Task<ActionResult<int>> DeleteClass(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                await _classmodel.DeleteClass(id);

            }
            catch (Exception ex)
            {
                return BadRequest(-1);
            }

            return Ok(1);
        }
    }
}
