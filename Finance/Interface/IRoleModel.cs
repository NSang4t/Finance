using Finance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Interface
{
    public interface IRoleModel
    {
        Task<List<RoleModel>> GetAllRoleModel();
        Task<int> AddRole(RoleModel role);
        Task<int> EditRole(int id, RoleModel rule);
        Task<int> DeleteRole(int id);
    }
}
