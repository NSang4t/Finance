using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Model
{
    public enum Gender
    {
        [Display(Name = "Nam")]
        Nam = 1,
        [Display(Name = "Nữ")]
        Nu = 2
    }
    //public enum admin
    //{
    //    [Display(Name = "Accountant_Chief")]
    //    chief = 1,
    //    [Display(Name = "Accounting_Enrollment")]
    //    Enrollment = 2,
    //    [Display(Name = "Accounting_salary")]
    //    salary = 3,
    //    [Display(Name = "Teacher")]
    //    teacher = 4,
    //}
    [Table("UserModel")]
    public class UserModel
    {
        [Key]
        public int User_ID { get; set; }
        public int RoleID { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Bạn Cần Nhập Tài Khoản"), Display(Name = "Tài Khoản")]
        public string UserName { get; set; }

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
        public Gender Gender { get; set; }

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
        public RoleModel roles   { get; set; }
        public int ClassID { get; set; }
        public ClassModel classs { get; set; }
        public TariffModel tariffModels { get; set; }
        [ForeignKey("TariffModel")]
        public int Id_Tariff { get; set; }
        public TimekeepingModel timekeepingModels { get; set; }
    }
    }

