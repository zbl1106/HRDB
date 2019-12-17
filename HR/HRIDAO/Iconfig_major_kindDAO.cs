using HRModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIDAO
{
   public interface Iconfig_major_kindDAO
    {
        Task<List<config_major_kind>> CFKSelect();
        Task<int> CFKAdd(config_major_kind ck);
        Task<int> CFKDel(config_major_kind ck);
    }
}
