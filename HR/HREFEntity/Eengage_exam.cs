using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Eengage_exam //表名
    {
        [Key]
        public int exa_id { get; set; }

        public System.String exam_number { get; set; }

        public System.String major_kind_id { get; set; }

        public System.String major_kind_name { get; set; }

        public System.String major_id { get; set; }

        public System.String major_name { get; set; }

        public System.String register { get; set; }

        public System.DateTime regist_time { get; set; }

        public int limite_time { get; set; }

    }

}
