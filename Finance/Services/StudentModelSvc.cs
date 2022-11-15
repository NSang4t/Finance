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
    public class StudentModelSvc : IStudentModel
    {
        protected DataContext _context;
        protected IEncode _mahoaHelper;
        public StudentModelSvc(DataContext context, IEncode mahoaHelper)
        {
            _context = context;
            _mahoaHelper = mahoaHelper;
        }
        public async Task<int> AddStudent(StudentModel student)
        {
            int ret = 0;
            try
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                ret = student.Id_Student;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }
        public StudentModel GetStudentsID(int id)
        {
            StudentModel student = null;
            student = _context.StudentModels.Find(id);
            return student;
        }
        public async Task<int> DeleteStudent(int id)
        {
            int ret = 0;
            try
            {
                var student = GetStudentsID(id);
                _context.Remove(student);
                await _context.SaveChangesAsync();
                ret = student.Id_Student;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<int> EditStudent(int id, StudentModel student)
        {
            int ret = 0;
            try
            {
                StudentModel st = new StudentModel();
                st = await _context.StudentModels.Where(a => a.Id_Student == st.Id_Student).FirstOrDefaultAsync();
                _context.Update(student);
                await _context.SaveChangesAsync();
                ret = st.Id_Class;
            }
            catch (Exception ex)
            {
                ret = 0;
            }
            return ret;
        }

        public async Task<List<StudentModel>> GetAllStudent()
        {
            List<StudentModel> list = new List<StudentModel>();
            list = await _context.StudentModels.ToListAsync();
            return list;
        }
    }
}
