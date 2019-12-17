using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Esalary_grant_detailsConfiger: EntityTypeConfiguration<Esalary_grant_details>
    {

        public Esalary_grant_detailsConfiger()
        {
            this.ToTable("salary_grant_details");
            
         }

      
    }
}
