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
    //客户化设置控制器:I级机构设置

    public class First_KindController : Controller
    {
        HRContext hr = new HRContext();
        // GET: Client
        public Iconfig_file_first_kindBLL Iconfig_file_first_kindBLL { get; set; }
      
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Index2()
        {
            List<HRModel.config_file_first_kind> list = await Iconfig_file_first_kindBLL.CFKSelect();
            string zhi = JsonConvert.SerializeObject(list);
            return Content(zhi);
        }

        //进入新增页面
        public ActionResult Create()
        {
            return View();
        }

        //新增
        [HttpPost]
        public async Task<ActionResult> Create(config_file_first_kind ck)
        {
            try
            {
                int result = await Iconfig_file_first_kindBLL.CFKAdd(ck);
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
            config_file_first_kind cc = new config_file_first_kind() { 
              ffk_id=id
            };
            int result= await Iconfig_file_first_kindBLL.CFKDel(cc);
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/First_Kind/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/First_Kind/Index'</script>");
            }
        }

        //修改
        public ActionResult Edit(int id)
        {
            Econfig_file_first_kind st = hr.Econfig_file_first_kind.AsNoTracking().Where(e => e.ffk_id.Equals(id)).FirstOrDefault();
            config_file_first_kind st2 = new config_file_first_kind()
            {   ffk_id = st.ffk_id,
                first_kind_id=st.first_kind_id,
                first_kind_name=st.first_kind_name,
                first_kind_salary_id=st.first_kind_salary_id,
                first_kind_sale_id=st.first_kind_sale_id
            };
            return View(st2);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, config_file_first_kind st)
        {
            try
            {
                string[] ps = new string[] { "ffk_id", "first_kind_id", "first_kind_name", "first_kind_salary_id", "first_kind_sale_id" };
                int result = await Iconfig_file_first_kindBLL.CFKUpdate(st,ps);
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

                return View(st);
            }
        }


        }
}