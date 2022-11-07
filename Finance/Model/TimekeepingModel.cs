using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Model
{
    public enum status
    {
        [Display(Name = "Finished")]
        Finished = 1,
        [Display(Name = "unfinished")]
        unfinished = 2
    }
    public class TimekeepingModel
    {
        [Key]
        public int ID_Timekeeping { get; set; }
        [ForeignKey("UserModel")]
        public int ID_User { get; set; }
        [ForeignKey("TeacherModel")]
        public int ID_Teacher { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime Date { get; set; }
        [Display(Name = " chấm công ")]
        public status Status { get; set; }
    }
}
