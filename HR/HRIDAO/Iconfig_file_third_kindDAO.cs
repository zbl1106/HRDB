using HRModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIDAO
{
   public interface Iconfig_file_third_kindDAO
    {
        Task<List<config_file_third_kind>> CTKSelect();
        Task<int> CTKAdd(config_file_third_kind ck);
        Task<int> CTKUpdate(config_file_third_kind ck, params string[] ps);
        Task<int> CTKDel(config_file_third_kind ck);
    }
}
