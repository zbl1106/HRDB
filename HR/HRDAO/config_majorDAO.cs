using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
using HREFEntity;
using HRIDAO;
namespace HRDAO
{
    public class config_majorDAO : DaoBase<Econfig_major>, Iconfig_majorDAO
    {
        public Task<int> CMAdd(config_major cm)
        {
            Econfig_major fm = new Econfig_major()
            {
                 major_id=cm.major_id,
                 major_kind_id=cm.major_kind_id,
                 major_kind_name=cm.major_kind_name,
                 major_name=cm.major_name,
                 mak_id=cm.mak_id,
                 test_amount=cm.test_amount 
            };
            return Add(fm);
        }

        public Task<int> CMDel(config_major cm)
        {
            Econfig_major fm = new Econfig_major() 
            {
             mak_id=cm.mak_id
            };
            return Del(fm);
        }

        public async Task<List<config_major>> CMSelect()
        {
            List<Econfig_major> fm = await GetAll();
            List<config_major> fm2 = new List<config_major>();
            foreach (var cm in fm)
            {
                config_major mm = new config_major() 
                {
                    major_id = cm.major_id,
                    major_kind_id = cm.major_kind_id,
                    major_kind_name = cm.major_kind_name,
                    major_name = cm.major_name,
                    mak_id = cm.mak_id,
                    test_amount = cm.test_amount
                };
                fm2.Add(mm);
            }
            return fm2;
        }
    }
}
