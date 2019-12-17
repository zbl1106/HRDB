using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIDAO;
using HRModel;
using HREFEntity;
namespace HRDAO
{
    public class config_major_kindDAO : DaoBase<Econfig_major_kind>, Iconfig_major_kindDAO
    {
        public Task<int> CFKAdd(config_major_kind ck)
        {
            Econfig_major_kind mk = GetMk(ck);
            return Add(mk);
        }

        private static Econfig_major_kind GetMk(config_major_kind ck)
        {
            return new Econfig_major_kind()
            {
                major_kind_id = ck.major_kind_id,
                mfk_id = ck.mfk_id,
                major_kind_name = ck.major_kind_name
            };
        }

        public Task<int> CFKDel(config_major_kind ck)
        {
            Econfig_major_kind mk = new Econfig_major_kind() 
            {
             mfk_id=ck.mfk_id
            };
            return Del(mk);
        }

        public async Task<List<config_major_kind>> CFKSelect()
        {
            List<Econfig_major_kind> mk = await GetAll();
            List<config_major_kind> mk2 = new List<config_major_kind>();
            foreach (var ck in mk)
            {
                config_major_kind ma = new config_major_kind() {
                 major_kind_id = ck.major_kind_id,
                mfk_id = ck.mfk_id,
                major_kind_name = ck.major_kind_name
                };
                mk2.Add(ma);
            }
            return mk2;
        }
    }
}
