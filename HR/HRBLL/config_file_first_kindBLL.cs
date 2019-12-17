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
    public class config_file_first_kindBLL : Iconfig_file_first_kindBLL
    {
        //属性注入
        public Iconfig_file_first_kindDAO Iconfig_file_first_kindDAO { get; set; }
        public Task<int> CFKAdd(config_file_first_kind ck)
        {
            return Iconfig_file_first_kindDAO.CFKAdd(ck);
        }

        public Task<int> CFKDel(config_file_first_kind ck)
        {
            return Iconfig_file_first_kindDAO.CFKDel(ck);
        }

        public Task<List<config_file_first_kind>> CFKSelect()
        {
            return Iconfig_file_first_kindDAO.CFKSelect();
        }

        public Task<int> CFKUpdate(config_file_first_kind ck, params string[] ps)
        {
            return Iconfig_file_first_kindDAO.CFKUpdate(ck,ps);
        }
    }
}
