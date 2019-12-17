using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Esalary_standard_detailsConfiger: EntityTypeConfiguration<Esalary_standard_details>
    {

        public Esalary_standard_detailsConfiger()
        {
            this.ToTable("salary_standard_details");
            
         }

      
    }
}
