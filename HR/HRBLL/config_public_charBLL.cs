using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIBLL;
using HRModel;
using HRIDAO;
using System.Linq.Expressions;
using HREFEntity;
namespace HRBLL
{
   public class config_public_charBLL:Iconfig_public_charBLL
    {
        public Iconfig_public_charDAO imk { get; set; }
        //职场设置页面查询
        public Task<List<config_public_char>> CMKSelect(Expression<Func<Econfig_public_char, bool>> where)
        {
            return imk.CMKSelect(where);
        }
        //公共属性添加
        public Task<int> AddSX(config_public_char pc)
        {
            return imk.AddSX(pc);
        }
        //公共属性查询
        public Task<List<config_public_char>> SelectSX()
        {
            return imk.SelectSX();
        }
        //薪酬查询  
        public Task<List<config_public_char>> SelectXC(Expression<Func<Econfig_public_char, bool>> where)
        {
            return imk.SelectXC(where);
        }
         //薪酬添加 
        public Task<int> AddXC(config_public_char pc)
        {
            return imk.AddXC(pc);
        }
       //薪酬删除 
        public Task<int> Del(config_public_char pc)
        {
            return imk.Del(pc);
        }
     
    }
}
