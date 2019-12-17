using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
    public class Econfig_question_first_kindConfiger: EntityTypeConfiguration<Econfig_question_first_kind>
    {

        public Econfig_question_first_kindConfiger()
        {
            this.ToTable("config_question_first_kind");
        }


    }
}
