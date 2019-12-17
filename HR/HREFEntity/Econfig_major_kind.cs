using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Econfig_major_kind //表名
    {
        [Key]
        public int mfk_id { get; set; }

        public System.String major_kind_id { get; set; }

        public System.String major_kind_name { get; set; }

    }

}
