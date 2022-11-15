using Finance.Helpers;
using Finance.Interface;
using Finance.Interfaces;
using Finance.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Services
{
    public class ClassModelSvc : ICLassModel
    {
        protected DataContext _context;
        protected IEncode _mahoaHelper;
        public ClassModelSvc(DataContext context, IEncode mahoaHelper)
        {
            _context = context;
            _mahoaHelper = mahoaHelper;
        }
        public async Task<int> AddClass(ClassModel classModel)
        {
            int ret = 0;
            try
            {
                _context.Add(classModel);
                await _context.SaveChangesAsync();
                ret = classModel.Id_Class;
              
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
        public UserModel GetClassID(int id)
        {
            UserModel user = null;
            user = _context.UserModels.Find(id);
            return user;
        }
        public async Task<int> DeleteClass(int id)
        {
            int ret = 0;
            try
            {
                var a = GetClassID(id);
                _context.Remove(a);
                await _context.SaveChangesAsync();
                ret = a.User_ID;

            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> EditClass(int id, ClassModel classModel)
        {
            int ret = 0;
            try
            {
                ClassModel st = new ClassModel();
                st = await _context.ClassModels.Where(a => a.Id_Class == st.Id_Class     ).FirstOrDefaultAsync();
                _context.Update(classModel);
                await _context.SaveChangesAsync();
                ret = classModel.Id_Class;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<List<ClassModel>> GetAllClass()
        {
            
            List<ClassModel> user = new List<ClassModel>();
            user = await _context.ClassModels.ToListAsync();
            return user;
        }
    }
}
