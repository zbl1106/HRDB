using HRModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIDAO
{
   public interface IStudentDAO
    {
        Task<List<Student>> StudentSelect();
        Task<int> StudentAdd(Student st);
        Task<int> StudentUpdate(Student st, params string[] ps);
        Task<int> StudentDel(Student st);
    }
}
