using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Finance.Model
{
    public enum Status
    {
        [Display(Name = "apply")]
        apply = 1,
        [Display(Name = "Stop_application")]
        Stop_application = 2,
         [Display(Name = "unprepared")]
        unprepared = 2
    }
    public class TariffModel
    {
        [Key]
        public int Id_Tariff { get; set; }
         public int CodeBill { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Bạn Cần Nhập ngày thu"), Display(Name = "ngày thu")]
        public DateTime Autumn  { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Bạn Cần Nhập số tiền"), Display(Name = "số tiền")]
        public string Money { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Bạn Cần Nhập nội dung thu"), Display(Name = "nội dung")]
        public string Content { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Bạn Cần Nhập tổng số tiền"), Display(Name = "tổng số tiền")]
        public string Total_Payment { get; set; }

        public Status Status { get; set; }
        [StringLength(10)]
        [Required(ErrorMessage = "Bạn Cần Nhập tên người cập nhật"), Display(Name = "tên người cập nhật ")]
        public string ModifyBy { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Bạn Cần Nhập ngày bắt đầu "), Display(Name = " ngày bắt đầu")]
        public DateTime StartDate { get; set; }
        [StringLength(10)]
        [Required(ErrorMessage = "Bạn Cần Nhập  ngày kết thúc"), Display(Name = "ngày kết thúc ")]
        public DateTime EndDate { get; set; }
        public ICollection<UserModel> userModels { get; set; }
        public ICollection<ExemptionsModel> exemptionsModels { get; set; }
    }
}
