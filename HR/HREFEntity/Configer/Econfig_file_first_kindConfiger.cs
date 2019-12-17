using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using HREFEntity;
namespace HREFEntity.Configer
{
    public class Econfig_file_first_kindConfiger : EntityTypeConfiguration<Econfig_file_first_kind>
    {

        public Econfig_file_first_kindConfiger()
        {
            this.ToTable("config_file_first_kind");
            
        }


    }
}
