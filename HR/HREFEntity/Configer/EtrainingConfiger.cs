using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class EtrainingConfiger: EntityTypeConfiguration<Etraining>
    {

        public EtrainingConfiger()
        {
            this.ToTable("training");
            
         }

      
    }
}
