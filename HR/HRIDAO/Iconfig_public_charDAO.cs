using HRModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HREFEntity;
namespace HRIDAO
{
   public interface Iconfig_public_charDAO
    {
        //职场设置页面查询
        Task<List<config_public_char>> CMKSelect(Expression<Func<Econfig_public_char, bool>> where);
        //公共属性设置查询
        Task<List<config_public_char>> SelectSX();
        //公共属性设置添加
        Task<int> AddSX(config_public_char pc);
        //查询薪酬项目设置内容
        Task<List<config_public_char>> SelectXC(Expression<Func<Econfig_public_char, bool>> where);
        //添加薪酬项目设置内容
        Task<int> AddXC(config_public_char pc);
        //删除薪酬项目设置内容
        Task<int> Del(config_public_char pc);

    }
}
