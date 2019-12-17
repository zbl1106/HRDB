using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Emajor_changeConfiger: EntityTypeConfiguration<Emajor_change>
    {

        public Emajor_changeConfiger()
        {
            this.ToTable("major_change");
            
         }

      
    }
}
