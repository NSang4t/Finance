using Finance.Model;
using Finance.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Interface
{
   public interface IUserModel
    {
        Task<int> ChangePasswordAdmin(string email, UserModel user);
        public Task<List<UserModel>> GetUserModelAllAsync();
        public Task<bool> EditUserModelAsync(int id, UserModel user);
        public Task<bool> AddUserModelAsync(UserModel user);
        public Task<UserModel> GetUserModelAsync(int? id);
        Task<bool> isEmail(string email);//kiem tra ton tai cua email
   
        Task<UserModel> LoginAsync(ViewLogin login);
        Task<int> ChangePasswordCode(string email, UserModel user);
    }
}
