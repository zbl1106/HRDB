using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Eengage_answer_detailsConfiger: EntityTypeConfiguration<Eengage_answer_details>
    {

        public Eengage_answer_detailsConfiger()
        {
            this.ToTable("engage_answer_details");
            
         }

      
    }
}
