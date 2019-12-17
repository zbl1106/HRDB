using HRModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIBLL
{
   public interface Iconfig_major_kindBLL
    {
        Task<List<config_major_kind>> CFKSelect();
        Task<int> CFKAdd(config_major_kind ck);
        Task<int> CFKDel(config_major_kind ck);
    }
}
