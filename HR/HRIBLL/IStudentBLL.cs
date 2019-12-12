using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
namespace HRIBLL
{
   public interface IStudentBLL
    {
        Task<List<Student>> StudentSelect();
        Task<int> StudentAdd(Student st);
        Task<int> StudentUpdate(Student st, params string[] ps);
        Task<int> StudentDel(Student st);
    }
}
