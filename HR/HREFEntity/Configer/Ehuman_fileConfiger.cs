using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Ehuman_fileConfiger: EntityTypeConfiguration<Ehuman_file>
    {
        public Ehuman_fileConfiger()
        {
            this.ToTable("human_file");
            
         }

      
    }
}
