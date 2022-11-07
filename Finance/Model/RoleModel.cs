using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Finance.Model
{

    [Table("Roles")]
    public class RoleModel
    {
        [Key , ForeignKey("UserModel")]
        public int RoleId { get; set; }

        [StringLength(20)]
        public string RoleName { get; set; }
    }
}
