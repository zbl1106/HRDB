using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Eusers //表名
    {
        [Key]
        public int u_id { get; set; }

        public System.String u_name { get; set; }

        public System.String u_true_name { get; set; }

        public System.String u_password { get; set; }

        public int RoleID { get; set; }
    }

}
