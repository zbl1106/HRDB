using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using HREFEntity;
namespace HREFEntity.Configer
{
    public class EbonusConfiger: EntityTypeConfiguration<Ebonus>
    {
        public EbonusConfiger()
        {
            this.ToTable("bonus");
        }
    }
}
