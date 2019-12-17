using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using HREFEntity;
using HRIBLL;
using HRModel;
using Newtonsoft.Json;

namespace HRUI.Controllers
{
    //客户化设置控制器:三级级机构设置
    public class third_kindController : Controller
    {
        HRContext hr = new HRContext();
        // GET: Client
        //属性注入
        public Iconfig_file_third_kindBLL itk { get; set; }
        public Iconfig_file_first_kindBLL ifk { get; set; }
        public Iconfig_file_second_kindBLL isk { get; set; }
        // GET: third_kind
        public ActionResult Index()
        {
            return View();
        }

        //查询
        public async Task<ActionResult> Index2()
        {
            List<config_file_third_kind> list = await itk.CTKSelect();
            string zhi = JsonConvert.SerializeObject(list);
            return Content(zhi);
        }

        //添加
        public async Task<ActionResult> Create()
        {   
            List<config_file_first_kind> list2 = await ifk.CFKSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var item in list2)
            {
                list.Add(new SelectListItem { Text = item.first_kind_name, Value = item.first_kind_id.ToString() + "," + item.first_kind_name });
            }
            ViewData["list"] = list;

            List<config_file_second_kind> list3 = await isk.CSKSelect();
            List<SelectListItem> list4 = new List<SelectListItem>();
            foreach (var item in list3)
            {
                list4.Add(new SelectListItem {Text=item.second_kind_name,Value=item.second_kind_id.ToString()+","+item.second_kind_name });
            }
            ViewData["list2"] = list4;
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(config_file_third_kind ck) 
        {
            try
            {
                string[] sz = ck.first_kind_name.Split(',');
                ck.first_kind_id = sz[0];
                ck.first_kind_name = sz[1];
                string[] sz2 = ck.second_kind_name.Split(',');
                ck.second_kind_id = sz2[0];
                ck.second_kind_name = sz2[1];
                int result = await itk.CTKAdd(ck); 
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(ck);
                }
            }
            catch (Exception)
            {
                return View(ck);
            }
        }

        //删除
        public async Task<ActionResult> Delete(int id)
        {
            config_file_third_kind ck = new config_file_third_kind() 
            {
             ftk_id=id
            };
            int result = await itk.CTKDel(ck);
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/third_kind/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/third_kind/Index'</script>");
            }
        }

        //修改
        public ActionResult Edit(int id)
        {
            Econfig_file_third_kind ck = hr.Econfig_file_third_kind.AsNoTracking().Where(e => e.ftk_id.Equals(id)).FirstOrDefault();
            config_file_third_kind st2 = new config_file_third_kind()
            {
                ftk_id = ck.ftk_id,
                first_kind_id = ck.first_kind_id,
                first_kind_name = ck.first_kind_name,
                second_kind_id = ck.second_kind_id,
                second_kind_name = ck.second_kind_name,
                third_kind_id = ck.third_kind_id,
                third_kind_name = ck.third_kind_name,
                third_kind_sale_id = ck.third_kind_sale_id,
                third_kind_is_retail = ck.third_kind_is_retail
            };
            return View(st2);
        }
        [HttpPost]
        public async Task<ActionResult> Edit(config_file_third_kind st)
        {
            try
            {
                string[] ps = new string[] { "ftk_id", "first_kind_id", "first_kind_name","second_kind_id", "second_kind_name", "third_kind_id", "third_kind_name", "third_kind_sale_id","third_kind_is_retail"};
                int result = await itk.CTKUpdate(st,ps);
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(st);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        }
}