using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIBLL;
using HRModel;
using HRIDAO;
namespace HRBLL
{
    public class config_file_second_kindBLL : Iconfig_file_second_kindBLL
    {
        //属性注入
        public Iconfig_file_second_kindDAO ick { get; set; }
        public Task<int> CSKAdd(config_file_second_kind ck)
        {
           return ick.CSKAdd(ck);
        }

        public Task<int> CSKDel(config_file_second_kind ck)
        {
            return ick.CSKDel(ck);
        }

        public Task<List<config_file_second_kind>> CSKSelect()
        {
            return ick.CSKSelect();
        }

        public Task<int> CSKUpdate(config_file_second_kind ck, params string[] ps)
        {
            return ick.CSKUpdate(ck,ps);
        }
    }
}
