using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
namespace HRIBLL
{
   public interface Iconfig_file_second_kindBLL
    {
        Task<List<config_file_second_kind>> CSKSelect();
        Task<int> CSKAdd(config_file_second_kind ck);
        Task<int> CSKUpdate(config_file_second_kind ck, params string[] ps);
        Task<int> CSKDel(config_file_second_kind ck);
    }
}
