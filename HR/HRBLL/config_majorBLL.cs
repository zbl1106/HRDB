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
    public class config_majorBLL : Iconfig_majorBLL
    {
        //属性注入
        public Iconfig_majorDAO ifm { get; set; }
        public Task<int> CMAdd(config_major cm)
        {
            return ifm.CMAdd(cm);
        }

        public Task<int> CMDel(config_major cm)
        {
            return ifm.CMDel(cm);
        }

        public Task<List<config_major>> CMSelect()
        {
            return ifm.CMSelect();
        }
    }
}
