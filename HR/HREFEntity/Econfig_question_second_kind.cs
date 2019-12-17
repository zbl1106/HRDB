using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Econfig_question_second_kind //表名
    {
        [Key]
        public int qsk_id { get; set; }

        public System.String first_kind_id { get; set; }

        public System.String first_kind_name { get; set; }

        public System.String second_kind_id { get; set; }

        public System.String second_kind_name { get; set; }

    }

}
