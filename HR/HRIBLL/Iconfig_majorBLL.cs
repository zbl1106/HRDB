using HRModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIBLL
{
  public  interface Iconfig_majorBLL
    {
        Task<List<config_major>> CMSelect();
        Task<int> CMAdd(config_major cm);
        Task<int> CMDel(config_major cm);
    }
}
