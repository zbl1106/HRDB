using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Eengage_exam_details //表名
    {
        [Key]
        public int exd_id { get; set; }

        public System.String exam_number { get; set; }

        public System.String first_kind_id { get; set; }

        public System.String first_kind_name { get; set; }

        public System.String second_kind_id { get; set; }

        public System.String second_kind_name { get; set; }

        public int question_amount { get; set; }

    }

}
