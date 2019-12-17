using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Econfig_majorConfiger: EntityTypeConfiguration<Econfig_major>
    {

        public Econfig_majorConfiger()
        {
            this.ToTable("config_major");
            
         }

      
    }
}
