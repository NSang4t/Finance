using Finance.Interface;
using Finance.Interfaces;
using Finance.Model;
using Finance.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Services
{
    public class UserModelSvc : IUserModel
    {
        protected DataContext _context;
        protected IEncode _mahoaHelper;
        public UserModelSvc(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> AddUserModelAsync(UserModel user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<UserModel> GetUserEmail(string email)
        {
            UserModel users = null;
            users = await _context.UserModels.FirstOrDefaultAsync(u => u.Email == email);
            return users;
        }
        public async Task<int> ChangePasswordCode(string email, UserModel user)
        {

            int ret = 0;
            try
            {

                UserModel _user = null;
                _user = await GetUserEmail(email);


                _user.Password = user.Password;
                _context.Update(_user);
                await _context.SaveChangesAsync();

                ret = user.User_ID;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<bool> EditUserModelAsync(int id, UserModel user)
        {
            _context.UserModels.Update(user);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<UserModel>> GetUserModelAllAsync()
        {
            var dataContext = _context.UserModels;
            return await dataContext.ToListAsync();
        }

        public async Task<UserModel> GetUserModelAsync(int? id)
        {
            var user = await _context.UserModels
              .FirstOrDefaultAsync(m => m.User_ID == id);
            if (user == null)
            {
                return null;
            }

            return user;
        }

        public async Task<bool> isEmail(string email)
        {
            bool ret = false;
            try
            {
                UserModel user = await _context.UserModels.Where(x => x.Email == email).FirstOrDefaultAsync();
                if (user != null)
                {
                    ret = true;
                }
                else
                {
                    ret = false;
                }
            }
            catch
            {
                ret = false;
            }
            return ret;
            
        }

        public async Task<UserModel> LoginAsync(ViewLogin login)
        {
            UserModel user = await _context.UserModels.Where(x => x.Email == login.Email
                   && x.Password == (login.Password)).FirstOrDefaultAsync();
            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
        public UserModel GetEmail(string email)
        {
            UserModel user = null;
            user = _context.UserModels.FirstOrDefault(m => m.Email == email);
            return user;
        }
        public async Task<int> ChangePasswordAdmin(string email, UserModel user)
        {
            int ret = 0;
            try
            {
                UserModel _cus = null;
                _cus = GetEmail(email);

                _cus.Password = _mahoaHelper.Encode(user.Password);

                _context.Update(_cus);
                await _context.SaveChangesAsync();
                ret = user.User_ID;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
    }
}
