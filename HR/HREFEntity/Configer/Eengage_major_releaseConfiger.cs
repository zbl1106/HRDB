using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
    public class Eengage_major_releaseConfiger: EntityTypeConfiguration<Eengage_major_release>
    {
        public Eengage_major_releaseConfiger()
        {
            this.ToTable("engage_major_release");
        }


    }
}
