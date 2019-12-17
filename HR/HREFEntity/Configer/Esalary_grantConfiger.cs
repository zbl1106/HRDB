using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace HREFEntity.Configer
{
public class Esalary_grantConfiger: EntityTypeConfiguration<Esalary_grant>
    {

        public Esalary_grantConfiger()
        {
            this.ToTable("salary_grant");
            
         }

      
    }
}
