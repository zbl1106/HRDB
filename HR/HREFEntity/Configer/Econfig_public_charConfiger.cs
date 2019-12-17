using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Econfig_public_charConfiger: EntityTypeConfiguration<Econfig_public_char>
    {

        public Econfig_public_charConfiger()
        {
            this.ToTable("config_public_char");
            
         }

      
    }
}
