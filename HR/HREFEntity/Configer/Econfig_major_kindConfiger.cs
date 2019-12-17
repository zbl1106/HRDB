using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Econfig_major_kindConfiger: EntityTypeConfiguration<Econfig_major_kind>
    { public Econfig_major_kindConfiger()
        {
            this.ToTable("config_major_kind");
         }
    }
}
