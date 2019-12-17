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
    public class config_file_second_kindDAO :DaoBase<Econfig_file_second_kind>,Iconfig_file_second_kindDAO
    {
        public Task<int> CSKAdd(config_file_second_kind ck)
        {
            Econfig_file_second_kind cs = new Econfig_file_second_kind()
            {
                fsk_id=ck.fsk_id,
                first_kind_id=ck.first_kind_id,
                first_kind_name=ck.first_kind_name,
                second_kind_id=ck.first_kind_id,
                second_kind_name=ck.second_kind_name,
                second_salary_id=ck.second_salary_id,
                second_sale_id=ck.second_sale_id
            };
            return Add(cs);
        }

        public Task<int> CSKDel(config_file_second_kind ck)
        {
            Econfig_file_second_kind cs = new Econfig_file_second_kind() 
            {
              fsk_id=ck.fsk_id
            };
            return Del(cs);
        }

        public async Task<List<config_file_second_kind>> CSKSelect()
        {
            List<Econfig_file_second_kind> cs = await GetAll();
            List<config_file_second_kind> cs2 = new List<config_file_second_kind>();
            foreach (var item in cs)
            {
                config_file_second_kind st = new config_file_second_kind()
                {
                    fsk_id = item.fsk_id,
                    first_kind_id = item.first_kind_id,
                    first_kind_name = item.first_kind_name,
                    second_kind_id = item.first_kind_id,
                    second_kind_name = item.second_kind_name,
                    second_salary_id = item.second_salary_id,
                    second_sale_id = item.second_sale_id
                };
                cs2.Add(st);
            }
            return cs2;
        }

        public Task<int> CSKUpdate(config_file_second_kind ck, params string[] ps)
        {
            Econfig_file_second_kind es = new Econfig_file_second_kind()
            {
                fsk_id = ck.fsk_id,
                first_kind_id = ck.first_kind_id,
                first_kind_name = ck.first_kind_name,
                second_kind_id = ck.first_kind_id,
                second_kind_name = ck.second_kind_name,
                second_salary_id = ck.second_salary_id,
                second_sale_id = ck.second_sale_id
            };
            return Update(es,ps);
        }
    }
}
