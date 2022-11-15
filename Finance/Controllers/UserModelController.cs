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
    public class UserModelController : ControllerBase
    {

        private readonly IUserModel _user;
        private readonly DataContext _context;
        public UserModelController(IUserModel user, DataContext context)
        {
            _context = context;
            _user = user;
        }

        [HttpPost]
        [ActionName("user")]
        public async Task<IActionResult> PostAsync(UserModel users)
        {
            if (ModelState.IsValid)
            {
                if (await _user.isEmail(users.Email))
                {
                    return Ok(new
                    {
                        retCode = 0,
                        retText = "Email đã tồn tại",
                        data = ""
                    });
                }
                else
                {
                    if (await _user.AddUserModelAsync(users))
                    {
                        return Ok(new
                        {
                            retCode = 1,
                            retText = "Thành công",
                            data = await _user.GetUserModelAsync(users.User_ID)
                        });
                    }
                }

            }
            return Ok(new
            {
                retCode = 0,
                retText = "Thất bại"
            });
        }
        [HttpGet]
        [Route("list-user")]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUserModelAllAsync()
        {

            return await _user.GetUserModelAllAsync(); ;
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, UserModel user)
        {
            if (id != user.User_ID)
            {
                return BadRequest();
            }


            if (!ModelState.IsValid)
                return BadRequest(ModelState);




            try
            {
                await _user.EditUserModelAsync(id, user);

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
        public async Task<IActionResult> DeleteUserModel(int id)
        {
            var user = await _context.UserModels.FindAsync(id);
            if (user == null)
            {
                return NotFound();

            }

            _context.UserModels.Remove(user);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{email}")]
        [ActionName("ChangePass")]
        public async Task<ActionResult<int>> ChangePassword(string email, UserModel user)
        {
            if (email != user.Email)
            {
                return BadRequest();
            }
            try
            {
                await _user.ChangePasswordAdmin(email, user);
                user.Email = email;
            }
            catch (Exception ex)
            {
                return BadRequest(-1);
            }
            return Ok(1);
        }
    }
}
