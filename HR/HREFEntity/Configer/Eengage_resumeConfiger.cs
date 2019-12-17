using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
    public class Eengage_resumeConfiger : EntityTypeConfiguration<Eengage_resume>
    {

        public Eengage_resumeConfiger()
        {
            this.ToTable("engage_resume");

        }


    }
}
