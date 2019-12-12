using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace HREFEntity.Configer
{
   public class EStduentConfiger:EntityTypeConfiguration<EStudent>
    {
        public EStduentConfiger()
        {
            this.ToTable("Student");
            this.Property(e => e.Name).HasMaxLength(30).IsRequired();
            this.Property(e => e.Age).IsRequired();
        }
    }
}
