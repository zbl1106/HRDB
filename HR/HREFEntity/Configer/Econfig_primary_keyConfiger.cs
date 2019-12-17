using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Econfig_primary_keyConfiger: EntityTypeConfiguration<Econfig_primary_key>
    {

        public Econfig_primary_keyConfiger()
        {
            this.ToTable("config_primary_key");
            
         }

      
    }
}
