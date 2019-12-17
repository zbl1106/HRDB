using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
    public class Eengage_interviewConfiger: EntityTypeConfiguration<Eengage_interview>
    {

        public Eengage_interviewConfiger()
        {
            this.ToTable("engage_interview");

        }


    }
}
