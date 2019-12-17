using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Esalary_grant //表名
    {
        [Key]
        public int sgr_id { get; set; }

        public System.String salary_grant_id { get; set; }

        public System.String salary_standard_id { get; set; }

        public System.String first_kind_id { get; set; }

        public System.String first_kind_name { get; set; }

        public System.String second_kind_id { get; set; }

        public System.String second_kind_name { get; set; }

        public System.String third_kind_id { get; set; }

        public System.String third_kind_name { get; set; }

        public int human_amount { get; set; }

        public System.Decimal salary_standard_sum { get; set; }

        public System.Decimal salary_paid_sum { get; set; }

        public System.String register { get; set; }

        public System.DateTime regist_time { get; set; }

        public System.String checker { get; set; }

        public System.DateTime check_time { get; set; }

        public int check_status { get; set; }

    }

}
