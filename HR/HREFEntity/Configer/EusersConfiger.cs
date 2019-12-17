using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
    public class EusersConfiger : EntityTypeConfiguration<Eusers>
    {
        public EusersConfiger()
        {
            this.ToTable("users");
        }
    }
}
