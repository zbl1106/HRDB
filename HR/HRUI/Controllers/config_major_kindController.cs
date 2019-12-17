using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HREFEntity;
using HRIBLL;
using HRModel;
using Newtonsoft.Json;
using System.Threading.Tasks;
namespace HRUI.Controllers
{
    public class config_major_kindController : Controller
    {
        // GET: config_major_kind
        HRContext hr = new HRContext();
        // GET: Client
        //属性注入
        public Iconfig_major_kindBLL isk { get; set; }
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Index2() 
        {
            List<config_major_kind> list = await isk.CFKSelect();
            string zhi = JsonConvert.SerializeObject(list);
            return Content(zhi);
        }
        //删除
        public async Task<ActionResult> Delete(int id)
        {
            config_major_kind cc = new config_major_kind()
            {
                 mfk_id=id
            };
            int result = await isk.CFKDel(cc);
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/config_major_kind/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/config_major_kind/Index'</script>");
            }
        }

   
        //进入新增页面
        public ActionResult Create()
        {
            return View();
        }

        //新增
        [HttpPost]
        public async Task<ActionResult> Create(config_major_kind ck)
        {
            try
            {
                int result = await isk.CFKAdd(ck);
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

    }
}