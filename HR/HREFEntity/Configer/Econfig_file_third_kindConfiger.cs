using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
    public class Econfig_file_third_kindConfiger : EntityTypeConfiguration<Econfig_file_third_kind>
    {

        public Econfig_file_third_kindConfiger()
        {
            this.ToTable("config_file_third_kind");
        }


    }
}
