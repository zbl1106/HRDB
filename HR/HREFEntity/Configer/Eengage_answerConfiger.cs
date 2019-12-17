using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Eengage_answerConfiger: EntityTypeConfiguration<Eengage_answer>
    {

        public Eengage_answerConfiger()
        {
            this.ToTable("engage_answer");
            
         }

      
    }
}
