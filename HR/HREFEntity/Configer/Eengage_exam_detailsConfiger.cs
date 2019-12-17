using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Eengage_exam_detailsConfiger: EntityTypeConfiguration<Eengage_exam_details>
    {

        public Eengage_exam_detailsConfiger()
        {
            this.ToTable("engage_exam_details");
            
         }

      
    }
}
