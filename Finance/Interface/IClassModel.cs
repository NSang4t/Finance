using Finance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Interface
{
    public interface ICLassModel
    {
        Task<List<ClassModel>> GetAllClass();
        Task<int> AddClass(ClassModel classModel);
        Task<int> EditClass(int id, ClassModel classModel);
        Task<int> DeleteClass(int id);
    }
}
