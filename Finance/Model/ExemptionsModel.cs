using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace Finance.Model
{
    public class ExemptionsModel
    {
        [Key, ForeignKey("TariffModel")]
        public int Id_Exemptions { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Bạn Cần Nhập tên chế độ miễn giảm"), Display(Name = "tên chế đ")]
        public string Name_Exemptions { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Bạn Cần Nhập số tiền "), Display(Name = "số tiền")]
        public string Money_Exemptions { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage = "Bạn Cần Nhập nội dung miễn giảm"), Display(Name = "nội dung")]
        public string Content { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Bạn Cần Nhập tổng số tiền"), Display(Name = "tổng số tiền")]
        public string Total_Payment { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Bạn Cần Nhập phần trăm miễn giảm"), Display(Name = "phần trăm miễn giảm ")]
        public string Percent { get; set; }
        [StringLength(10)]
        [Required(ErrorMessage = "Bạn Cần Nhập tên người cập nhật"), Display(Name = "tên người cập nhật ")]
        public string ModifyBy { get; set; }


        [StringLength(10)]
        [Required(ErrorMessage = "Bạn Cần Nhập ngày bắt đầu "), Display(Name = " ngày bắt đầu")]
        public DateTime StartDate { get; set; }
        [StringLength(10)]
        [Required(ErrorMessage = "Bạn Cần Nhập  ngày kết thúc"), Display(Name = "ngày kết thúc ")]
        public DateTime EndDate { get; set; }
        public TariffModel tariffModels { get; set; }
    }
}
