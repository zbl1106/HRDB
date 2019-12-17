using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HREFEntity
{

    public class Eengage_interview //表名
    {
        [Key]
        public int ein_id { get; set; }

        public System.String human_name { get; set; }

        public int interview_amount { get; set; }

        public System.String human_major_kind_id { get; set; }

        public System.String human_major_kind_name { get; set; }

        public System.String human_major_id { get; set; }

        public System.String human_major_name { get; set; }

        public System.String image_degree { get; set; }

        public System.String native_language_degree { get; set; }

        public System.String foreign_language_degree { get; set; }

        public System.String response_speed_degree { get; set; }

        public System.String EQ_degree { get; set; }

        public System.String IQ_degree { get; set; }

        public System.String multi_quality_degree { get; set; }

        public System.String register { get; set; }

        public System.String checker { get; set; }

        public System.DateTime registe_time { get; set; }

        public System.DateTime check_time { get; set; }

        public int resume_id { get; set; }

        public System.String result { get; set; }

        public System.String interview_comment { get; set; }

        public System.String check_comment { get; set; }

        public int interview_status { get; set; }

        public int check_status { get; set; }

    }

}
