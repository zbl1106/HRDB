using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HREFEntity;
using HRModel;
using Newtonsoft.Json;
using System.Threading.Tasks;
using HRIBLL;
namespace HRUI.Controllers
{
  
    public class config_majorController : Controller
    {
        HRContext hr = new HRContext();
        //属性注入
        public Iconfig_majorBLL ifm { get; set; }
    // GET: config_major
    public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Index2()
        {
            List<config_major> list = await ifm.CMSelect();
            string zhi = JsonConvert.SerializeObject(list);
            return Content(zhi);
        }

        public ActionResult Create() 
        {
            return View();
        }

        //新增
        [HttpPost]
        public async Task<ActionResult> Create(config_major ck)
        {
            try
            {
                int result = await ifm.CMAdd(ck);
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
            config_major cc = new config_major()
            {
                mak_id=id
            };
            int result = await ifm.CMDel(cc);
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/config_major/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/config_major/Index'</script>");
            }
        }

    }
}