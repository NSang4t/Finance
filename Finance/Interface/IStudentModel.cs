using Finance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Interface
{
   public interface IStudentModel
    {
        Task<List<StudentModel>> GetAllStudent();
        Task<int> AddStudent(StudentModel student);
        Task<int> EditStudent(int id, StudentModel student);
        Task<int> DeleteStudent(int id);
    }
}
