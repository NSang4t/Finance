using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Model
{
    public enum Type
    {
        [Display(Name = "formal")]
        formal = 1,
        [Display(Name = "connected")]
        connected = 2
    }
    public class ClassModel
    {
        [Key]
        public int Id_Class { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Bạn Cần Nhập Tên Lớp Học"), Display(Name = "Tên Lớp Học")]
        public string Name_Class { get; set; }
        [Required(ErrorMessage = "Bạn Cần Nhập Số lượng lớp học"), Display(Name = "Số Lượng ")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Niên khóa"), Display(Name = "Niên khóa ")]
        public string School_Year { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Bạn Cần Nhập tên chuyên ngành"), Display(Name = "tên chuyên ngành ")]
        public string Majors { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập số tín chỉ"), Display(Name = "số tín chỉ ")]
        public int Credit { get; set; }
        [Display(Name = "Type_education")]
        public Type Type_Education { get; set; }

    

        [Required(ErrorMessage = "Bạn Cần Nhập trạng thái"), Display(Name = "trạng thái ")]
        public bool Status { get; set; }

        
        [Required(ErrorMessage = "Bạn Cần Nhập tên Biểu phí"), Display(Name = " tên Biểu phí ")]
        public string Tariff_Name { get; set; }

      
        [Required(ErrorMessage = "Bạn Cần Nhập số lượng Biểu phí"), Display(Name = " số lượng Biểu phí ")]
        public string Tariff_Number{ get; set; }

        public ICollection<UserModel> userModels { get; set; }
        [ForeignKey("Teacher_ID")]
        public ICollection<TeacherModel> teacherModels { get; set; }
        public ICollection<StudentModel> studentModels { get; set; }
    }
}
