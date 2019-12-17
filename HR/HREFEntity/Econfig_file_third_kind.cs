using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Econfig_file_third_kind //表名
    {
        [Key]
        public int ftk_id { get; set; }

        public string first_kind_id { get; set; }

        public System.String first_kind_name { get; set; }

        public System.String second_kind_id { get; set; }

        public System.String second_kind_name { get; set; }

        public System.String third_kind_id { get; set; }

        public System.String third_kind_name { get; set; }

        public System.String third_kind_sale_id { get; set; }

        public System.String third_kind_is_retail { get; set; }

    }

}
