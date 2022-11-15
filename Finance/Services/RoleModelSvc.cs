using Finance.Interface;
using Finance.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Services
{
    public class RoleModelSvc : IRoleModel
    {
        protected DataContext _context;
        public RoleModelSvc(DataContext context)
        {
            _context = context;
        }

        public async Task<int> AddRole(RoleModel role)
        {
            int ret = 0;
            try
            {
                RoleModel rolemodel = new RoleModel();
                rolemodel = await _context.RoleModels.Where(g => g.RoleId == role.RoleId).FirstOrDefaultAsync();

                


                _context.Add(role);
                await _context.SaveChangesAsync();
                ret = role.RoleId;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public Task<int> DeleteRole(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<RoleModel> GetRoleId(int id)
        {
            RoleModel role = null;
            role = await _context.RoleModels.FirstOrDefaultAsync(m => m.RoleId == id);
            return role;
        }
        public Task<int> EditRole(int id, RoleModel rule)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RoleModel>> GetAllRoleModel()
        {
            List<RoleModel> list = new List<RoleModel>();
            list = await _context.RoleModels.ToListAsync();
            return list;
        }
        public RoleModel GetRoleIdFind(int id)
        {
            RoleModel role = null;
            role = _context.RoleModels.Find(id);
            return role;
        }
    }
}
