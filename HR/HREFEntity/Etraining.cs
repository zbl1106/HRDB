using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Etraining //表名
    {
        [Key]
        public int tra_id { get; set; }

        public System.String major_kind_id { get; set; }

        public System.String major_kind_name { get; set; }

        public System.String major_id { get; set; }

        public System.String major_name { get; set; }

        public System.String human_id { get; set; }

        public System.String human_name { get; set; }

        public System.String training_item { get; set; }

        public System.DateTime training_time { get; set; }

        public int training_hour { get; set; }

        public System.String training_degree { get; set; }

        public System.String register { get; set; }

        public System.String checker { get; set; }

        public System.DateTime regist_time { get; set; }

        public System.DateTime check_time { get; set; }

        public int checkstatus { get; set; }

        public System.String remark { get; set; }

    }

}
