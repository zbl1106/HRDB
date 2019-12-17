using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
using System.Threading.Tasks;
namespace HRIDAO
{
   public interface Iconfig_majorDAO
    {
        Task<List<config_major>> CMSelect();
        Task<int> CMAdd(config_major cm);
        Task<int> CMDel(config_major cm);
    }
}
