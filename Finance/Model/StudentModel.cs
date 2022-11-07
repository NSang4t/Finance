using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Finance.Model
{
    public enum TypeNumber
    {
        [Display(Name = "formal")]
        formal = 1,
        [Display(Name = "connected")]
        connected = 2
    }
    public class StudentModel
    {
        [Key]
        public int Id_Student { get; set; }
        public int Id_Profile { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Bạn Cần Nhập Họ Tên"), Display(Name = "Họ & Tên")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Email"), Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Email Không Hợp Lệ")]
        public string Email { get; set; }

        [Required, Range(1, int.MaxValue, ErrorMessage = "Chọn Giới Tính")]
        [Display(Name = "Giới Tính")]
        //[EnumDataType(typeof(Gender))]
        public Gender GioiTinh { get; set; }

        [Required(ErrorMessage = "Chọn Ngày Sinh"), Display(Name = "Ngày Sinh")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

        public DateTime? NgaySinh { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Địa Chỉ"), Display(Name = "Địa Chỉ")]
        [StringLength(200)]
        public string DiaChi { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Số Điện Thoại"), Display(Name = "Số Điện Thoại")]
        [Column(TypeName = "varchar(15)"), MaxLength(15)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{4})[-. ]?([0-9]{3})$", ErrorMessage = "Số Điện Thoại Không Hợp Lệ")]
        public string DienThoai { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập Số CMND "), Display(Name = "Số CMND")]
        [Column(TypeName = "varchar(20)"), MaxLength(20)]
        public string Card { get; set; }

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

        [Display(Name = "Type_education")]
        public TypeNumber Type_Education { get; set; }
        public bool IsDelete { get; set; }
        [ForeignKey ("ClassModel")]
        public int Id_Class { get; set; }
    }
}
