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
    public class config_file_third_kindDAO :DaoBase<Econfig_file_third_kind>, Iconfig_file_third_kindDAO
    {
        public  Task<int> CTKAdd(config_file_third_kind ck)
        {
            Econfig_file_third_kind cs = GetCs(ck);
            return Add(cs);
        }

        private static Econfig_file_third_kind GetCs(config_file_third_kind ck)
        {
            return new Econfig_file_third_kind()
            {
                ftk_id = ck.ftk_id,
                first_kind_id = ck.first_kind_id,
                first_kind_name = ck.first_kind_name,
                second_kind_id = ck.second_kind_id,
                second_kind_name = ck.second_kind_name,
                third_kind_id = ck.third_kind_id,
                third_kind_name = ck.third_kind_name,
                third_kind_sale_id = ck.third_kind_sale_id,
                third_kind_is_retail = ck.third_kind_is_retail,
            };
        }

        public Task<int> CTKDel(config_file_third_kind ck)
        {
            Econfig_file_third_kind tk = new Econfig_file_third_kind() 
            {
             ftk_id=ck.ftk_id
            };
            return Del(tk);
        }

        public async Task<List<config_file_third_kind>> CTKSelect()
        {
            List<Econfig_file_third_kind> cs = await GetAll();
            List<config_file_third_kind> cs2 = new List<config_file_third_kind>();
            foreach (var ck in cs)
            {
                config_file_third_kind st = new config_file_third_kind()
                {
                    ftk_id = ck.ftk_id,
                    first_kind_id = ck.first_kind_id,
                    first_kind_name = ck.first_kind_name,
                    second_kind_id = ck.second_kind_id,
                    second_kind_name = ck.second_kind_name,
                    third_kind_id = ck.third_kind_id,
                    third_kind_name = ck.third_kind_name,
                    third_kind_sale_id = ck.third_kind_sale_id,
                    third_kind_is_retail = ck.third_kind_is_retail,
                };
                cs2.Add(st);
            }
            return cs2;
        }

        public Task<int> CTKUpdate(config_file_third_kind ck, params string[] ps)
        {
            Econfig_file_third_kind cs= GetCs(ck);
            return Update(cs,ps);
        }
    }
}
