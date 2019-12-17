using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Esalary_standardConfiger: EntityTypeConfiguration<Esalary_standard>
    {

        public Esalary_standardConfiger()
        {
            this.ToTable("salary_standard");
            
         }

      
    }
}
