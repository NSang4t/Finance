using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Model
{
    public enum Gender2
    {
        [Display(Name = "Nam")]
        Nam = 1,
        [Display(Name = "Nữ")]
        Nu = 2
    }
    public class TeacherModel
    {
        [Key]
        public int Teacher_ID { get; set; }

         [StringLength(100)]
        [Required(ErrorMessage = "Bạn Cần Nhập Họ Tên"), Display(Name = "Họ & Tên")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Email"), Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Email Không Hợp Lệ")]
        public string Email { get; set; }

        [Required, Range(1, int.MaxValue, ErrorMessage = "Chọn Giới Tính")]
        [Display(Name = "Giới Tính")]
     
        public Gender2  Gender { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Sinh"), Display(Name = "Ngày Sinh")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime? Birthday { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Địa Chỉ"), Display(Name = "Địa Chỉ")]
        [StringLength(200)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Số Điện Thoại"), Display(Name = "Số Điện Thoại")]
        [Column(TypeName = "varchar(15)"), MaxLength(15)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{4})[-. ]?([0-9]{3})$", ErrorMessage = "Số Điện Thoại Không Hợp Lệ")]
        public string Phone { get; set; }

        [Display(Name = "Sử Dụng")]
        public bool Status { get; set; }

        [Required(ErrorMessage = "Nhập Mật Khẩu"), Display(Name = "Mật Khẩu")]
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Nhập Lại Mật Khẩu"), Display(Name = "Nhập Lại Mật Khẩu")]
        [Column(TypeName = "varchar(50)"), MaxLength(50)]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Mật Khẩu Không Khớp")]
        public string ConfirmPassword { get; set; }

        public bool IsDelete { get; set; }
        public TimekeepingModel timekeepingModels { get; set; }
    }
}
