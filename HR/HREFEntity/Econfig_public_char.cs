using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Econfig_public_char //表名
    {
        [Key]
        public int pbc_id { get; set; }

        public System.String attribute_kind { get; set; }

        public System.String attribute_name { get; set; }

    }

}
