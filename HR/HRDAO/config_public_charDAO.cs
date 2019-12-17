using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIDAO;
using HRModel;
using HREFEntity;
using System.Linq.Expressions;

namespace HRDAO
{
    public class config_public_charDAO : DaoBase<Econfig_public_char>, Iconfig_public_charDAO
    {

        //职场设置页面查询
        public async Task<List<config_public_char>> CMKSelect(Expression<Func<Econfig_public_char, bool>> where)
        {
            List<Econfig_public_char> mk = await GetWhere(where);
            List<config_public_char> mk2 = new List<config_public_char>();
            foreach (var item in mk)
            {
                config_public_char ck = new config_public_char()
                {
                    pbc_id = item.pbc_id,
                    attribute_name = item.attribute_name,
                    attribute_kind = item.attribute_kind
                };
                mk2.Add(ck);
            }
            return mk2;
        }
        //公共属性添加
        public Task<int> AddSX(config_public_char pc)
        {
            Econfig_public_char cph = GetCph(pc);
            return Add(cph);
        }

        private static Econfig_public_char GetCph(config_public_char pc)
        {
            return new Econfig_public_char()
            {
                pbc_id = pc.pbc_id,
                attribute_name = pc.attribute_name,
                attribute_kind = pc.attribute_kind
            };
        }


        //公共属性查询
        public async Task<List<config_public_char>> SelectSX()
        {
            List<Econfig_public_char> cp = await GetAll();
            List<config_public_char> cp2 = new List<config_public_char>();
            foreach (var pc in cp)
            {
                config_public_char cc = new config_public_char()
                {
                    pbc_id = pc.pbc_id,
                    attribute_name = pc.attribute_name,
                    attribute_kind = pc.attribute_kind
                };
                cp2.Add(cc);
            }
            return cp2;
        }

        //薪酬查询    
        public async Task<List<config_public_char>> SelectXC(Expression<Func<Econfig_public_char, bool>> where)
        {
            List<Econfig_public_char> pc = await GetWhere(where);
            List<config_public_char> pc2 = new List<config_public_char>();
            foreach (var item in pc)
            {
                config_public_char cc = new config_public_char()
                {
                    pbc_id = item.pbc_id,
                    attribute_name = item.attribute_name,
                    attribute_kind = item.attribute_kind
                };
                pc2.Add(cc);
            }
            return pc2;
        }
        //薪酬添加
        public Task<int> AddXC(config_public_char pc)
        {
            Econfig_public_char cc = GetCph(pc);
            return Add(cc);
        }

        //删除 
        public Task<int> Del(config_public_char pc)
        {
            Econfig_public_char cc = new Econfig_public_char()
            {
                pbc_id = pc.pbc_id
            };
            return Del(cc);
        }
    }
}
