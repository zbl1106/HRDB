using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Econfig_major //表名
    {
        [Key]
        public int mak_id { get; set; }

        public System.String major_kind_id { get; set; }

        public System.String major_kind_name { get; set; }

        public System.String major_id { get; set; }

        public System.String major_name { get; set; }

        public int test_amount { get; set; }

    }

}
