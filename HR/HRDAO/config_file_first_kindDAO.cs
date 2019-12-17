using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRModel;
using HRIDAO;
using HREFEntity;

namespace HRDAO
{
    public class config_file_first_kindDAO :DaoBase<HREFEntity.Econfig_file_first_kind>,Iconfig_file_first_kindDAO
    {
        public Task<int> CFKAdd(HRModel.config_file_first_kind ck)
        {
            //添加
            HREFEntity.Econfig_file_first_kind ss = new HREFEntity.Econfig_file_first_kind()
            {
                ffk_id= ck.ffk_id,                                //主键，自动增长列
                first_kind_name= ck.first_kind_name,             //一级机构名称
                first_kind_id = ck.first_kind_id,                 //一级机构编号
                first_kind_salary_id = ck.first_kind_salary_id,   //: 一级机构薪酬发放责任人编号 
               	first_kind_sale_id= ck.first_kind_sale_id       //: 一级机构销售责任人编号   
            };
            return Add(ss);  //调用daobase的add方法
        }

        public Task<int> CFKDel(HRModel.config_file_first_kind ck)
        {
            HREFEntity.Econfig_file_first_kind ss = new HREFEntity.Econfig_file_first_kind()
            {
                ffk_id= ck.ffk_id
            };
            return Del(ss);  //调用daobase的del方法
        }

        public async Task<List<HRModel.config_file_first_kind>> CFKSelect()
        {
            List<HREFEntity.Econfig_file_first_kind> ck = await GetAll();
            List<HRModel.config_file_first_kind> ck2 = new List<HRModel.config_file_first_kind>();
            foreach (var item in ck)
            {
                HRModel.config_file_first_kind st = new HRModel.config_file_first_kind()
                {
                    ffk_id = item.ffk_id,                                //主键，自动增长列
                    first_kind_name = item.first_kind_name,             //一级机构名称
                    first_kind_id = item.first_kind_id,                 //一级机构编号
                    first_kind_salary_id = item.first_kind_salary_id,   //: 一级机构薪酬发放责任人编号 
                    first_kind_sale_id = item.first_kind_sale_id       //: 一级机构销售责任人编号   
                };
                ck2.Add(st);
            }
            return ck2;
        }

        public Task<int> CFKUpdate(HRModel.config_file_first_kind ck, params string[] ps)
        {
            HREFEntity.Econfig_file_first_kind ss = new HREFEntity.Econfig_file_first_kind()
            {
                ffk_id = ck.ffk_id,                                //主键，自动增长列
                first_kind_name = ck.first_kind_name,             //一级机构名称
                first_kind_id = ck.first_kind_id,                 //一级机构编号
                first_kind_salary_id = ck.first_kind_salary_id,   //: 一级机构薪酬发放责任人编号 
                first_kind_sale_id = ck.first_kind_sale_id       //: 一级机构销售责任人编号   
            };
            return Update(ss, ps);
        }

        //public async Task<List<M_users>> selectUser()
        //{
        //    List<users> list = await GetAll();
        //    List<M_users> list2 = new List<M_users>();


        //    foreach (users item in list)
        //    {

        //        M_users us = new M_users();
        //        PropertyInfo[] propertys = us.GetType().GetProperties();
        //        PropertyInfo[] propertys2 = item.GetType().GetProperties();
        //        object obj = null;
        //        foreach (PropertyInfo property in propertys2)
        //        {
        //            foreach (PropertyInfo pp in propertys)
        //            {
        //                if (property.Name == pp.Name)
        //                {
        //                    obj = property.GetValue(item, null);
        //                    pp.SetValue(us, obj, null);
        //                    break;
        //                }
        //            }

        //        }
        //        list2.Add(us);
        //    }

        //    return list2;
        //}



    }
}
