using Finance.Interface;
using Finance.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleModel _role;


        public RoleController(IRoleModel rolemodel)
        {
            _role = rolemodel;

        }

        [HttpGet]
        [ActionName("get")]
        public async Task<ActionResult<IEnumerable<RoleModel>>> GetRoleAll()
        {
            var list = await _role.GetAllRoleModel();
            return list;
        }

        [HttpPost]
        [ActionName("create")]
        public async Task<ActionResult> AddRole(RoleModel rule)
        {
            try
            {
                int id = await _role.AddRole(rule);
                rule.RoleId = id;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(1);
        }

        [HttpPut("{id}")]
        [ActionName("update")]
        public async Task<ActionResult> UpdateRule(int id, RoleModel rule)
        {
            if (id != rule.RoleId)
            {
                return BadRequest();
            }
            try
            {
                await _role.EditRole(id, rule);
                rule.RoleId = id;
            }
            catch (Exception ex)
            {
                return BadRequest(-1);
            }
            return Ok(1);
        }

        [HttpDelete("{id}")]
        [ActionName("rule")]
        public async Task<ActionResult<int>> DeleteRule(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                await _role.DeleteRole(id);

            }
            catch (Exception ex)
            {
                return BadRequest(-1);
            }

            return Ok(1);
        }
    }
}
