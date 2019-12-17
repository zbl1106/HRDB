using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Econfig_question_first_kind //表名
    {
        [Key]
        public int qfk_id { get; set; }

        public System.String first_kind_id { get; set; }

        public System.String first_kind_name { get; set; }

    }

}
