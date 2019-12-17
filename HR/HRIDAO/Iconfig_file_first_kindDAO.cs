using HRModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIDAO
{
   public interface Iconfig_file_first_kindDAO
    {
        Task<List<config_file_first_kind>> CFKSelect();
        Task<int> CFKAdd(config_file_first_kind ck);
        Task<int> CFKUpdate(config_file_first_kind ck, params string[] ps);
        Task<int> CFKDel(config_file_first_kind ck);
    }
}
