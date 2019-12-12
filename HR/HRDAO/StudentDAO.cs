using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIDAO;
using HRModel;
using HREFEntity;
namespace HRDAO
{
    public class StudentDAO : DaoBase<EStudent>, IStudentDAO
    {

        //添加
        public Task<int> StudentAdd(Student st)
        {
            EStudent ss = new EStudent() {
                Id = st.Id,
                Age = st.Age,
                Name = st.Name
            };
            return Add(ss);  //调用daobase的add方法
        }

        public Task<int> StudentDel(Student st)
        {
            EStudent ss = new EStudent() { 
             Id=st.Id
            };
           return Del(ss);  //调用daobase的del方法
        }

        public async Task<List<Student>> StudentSelect()
        {
            List<EStudent> list = await GetAll();
            List<Student> list2 = new List<Student>();
            foreach (var item in list)
            {
                Student st = new Student()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Age = item.Age
                };
                list2.Add(st);
            }
            return list2;
        }

        public Task<int> StudentUpdate(Student st, params string[] ps)
        {
            EStudent ss = new EStudent()
            {
                Id=st.Id,
                Name=st.Name,
                Age=st.Age
            };
            return Update(ss,ps);
        }
    }
}
