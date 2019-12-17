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
    public class config_major_kindBLL : Iconfig_major_kindBLL
    {
        //属性注入
        public Iconfig_major_kindDAO imk { get; set; }
        public Task<int> CFKAdd(config_major_kind ck)
        {
            return imk.CFKAdd(ck);
        }

        public Task<int> CFKDel(config_major_kind ck)
        {
            return imk.CFKDel(ck);
        }

        public Task<List<config_major_kind>> CFKSelect()
        {
            return imk.CFKSelect();
        }
    }
}
