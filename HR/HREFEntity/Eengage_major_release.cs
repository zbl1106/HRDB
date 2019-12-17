using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Eengage_major_release //表名
    {
        [Key]
        public int mre_id { get; set; }

        public System.String first_kind_id { get; set; }

        public System.String first_kind_name { get; set; }

        public System.String second_kind_id { get; set; }

        public System.String second_kind_name { get; set; }

        public System.String third_kind_id { get; set; }

        public System.String third_kind_name { get; set; }

        public System.String major_kind_id { get; set; }

        public System.String major_kind_name { get; set; }

        public System.String major_id { get; set; }

        public System.String major_name { get; set; }

        public int human_amount { get; set; }

        public System.String engage_type { get; set; }

        public System.DateTime deadline { get; set; }

        public System.String register { get; set; }

        public System.String changer { get; set; }

        public System.DateTime regist_time { get; set; }

        public System.DateTime change_time { get; set; }

        public System.String major_describe { get; set; }

        public System.String engage_required { get; set; }

    }

}
