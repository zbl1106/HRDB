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
    public class config_file_third_kindBLL : Iconfig_file_third_kindBLL
    {
        public Iconfig_file_third_kindDAO ftk { get; set; }
        public Task<int> CTKAdd(config_file_third_kind ck)
        {
            return ftk.CTKAdd(ck);
        }

        public Task<int> CTKDel(config_file_third_kind ck)
        {
            return ftk.CTKDel(ck);
        }

        public Task<List<config_file_third_kind>> CTKSelect()
        {
            return ftk.CTKSelect();
        }

        public Task<int> CTKUpdate(config_file_third_kind ck, params string[] ps)
        {
            return ftk.CTKUpdate(ck,ps);
        }
    }
}
