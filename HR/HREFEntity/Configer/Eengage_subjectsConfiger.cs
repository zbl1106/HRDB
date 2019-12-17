using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Eengage_subjectsConfiger: EntityTypeConfiguration<Eengage_subjects>
    {

        public Eengage_subjectsConfiger()
        {
            this.ToTable("engage_subjects");
            
         }

      
    }
}
