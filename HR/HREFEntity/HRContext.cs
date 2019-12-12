using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HREFEntity
{
   public class HRContext:DbContext
    {
        public HRContext():base("name=sql")
        {
            //zbl
            //如果模型有变，就重新创建数据库
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDbContext>());
            //取消EF后期操作	
            Database.SetInitializer<HRContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //读取模型的配置信息
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<EStudent> EStudent { get; set; }
    }
}
