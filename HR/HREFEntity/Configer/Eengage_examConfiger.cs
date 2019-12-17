using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
    public class Eengage_examConfiger: EntityTypeConfiguration<Eengage_exam>
    {
        public Eengage_examConfiger()
        {
            this.ToTable("engage_exam");

        }


    }
}
