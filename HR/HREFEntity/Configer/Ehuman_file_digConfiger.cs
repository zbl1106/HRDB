using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Ehuman_file_digConfiger: EntityTypeConfiguration<Ehuman_file_dig>
    {

        public Ehuman_file_digConfiger()
        {
            this.ToTable("human_file_dig");
            
         }

      
    }
}
