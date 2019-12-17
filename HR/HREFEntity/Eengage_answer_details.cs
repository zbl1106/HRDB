using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Eengage_answer_details //表名
    {
        [Key]
        public int and_id { get; set; }

        public System.String answer_number { get; set; }

        public int subject_id { get; set; }

        public System.String answer { get; set; }

    }

}
