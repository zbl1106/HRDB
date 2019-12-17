using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Esalary_standard_details //表名
    {
        [Key]
        public int sdt_id { get; set; }

        public System.String standard_id { get; set; }

        public System.String standard_name { get; set; }

        public int item_id { get; set; }

        public System.String item_name { get; set; }

        public System.Decimal salary { get; set; }

    }

}
