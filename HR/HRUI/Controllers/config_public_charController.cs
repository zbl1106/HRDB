using HREFEntity;
using HRIBLL;
using HRModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HRUI.Controllers
{
    public class config_public_charController : Controller
    {
        //客户化设置控制器:职称设置
        HRContext hr = new HRContext();
        //属性注入
        public Iconfig_public_charBLL imk { get; set; }
        //进入职场设置页面
        public ActionResult Index()
        {
            return View();
        }
        //进入职场设置页面显示内容
        public async Task<ActionResult> Index2()
        {
            List<config_public_char> list = await imk.CMKSelect(e=>e.attribute_kind.Equals("职称"));
            string zhi = JsonConvert.SerializeObject(list);
            return Content(zhi);
        }
        //职场设置页面删除
        public async Task<ActionResult> Delete(int id)
        {
            config_public_char cc = new config_public_char()
            {
                pbc_id = id
            };
            int result = await imk.Del(cc);
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/config_public_char/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/config_public_char/Index'</script>");
            }
        }
        //进入公共属性设置页面
        public ActionResult Ggsx() 
        {
            return View();
        }
        //进入公共属性设置页面显示内容
        public async Task<ActionResult> Ggsx2() 
        {
            List<config_public_char> list = await imk.SelectSX();
            string zhi = JsonConvert.SerializeObject(list);
            return Content(zhi);
        }
        //公共属性设置删除
        public async Task<ActionResult> DeleteSX(int id)
        {
            config_public_char cc = new config_public_char() 
            {
             pbc_id=id
            };
            int result = await imk.Del(cc);
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/config_public_char/Ggsx'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/config_public_char/Ggsx'</script>");
            }
        }
        //公共属性添加
        public ActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        //公共属性添加
        public async Task<ActionResult> Create(config_public_char pc)
        {
            try
            {
                int result = await imk.AddSX(pc);
                if (result > 0)
                {
                    return RedirectToAction("Ggsx");
                }
                else
                {
                    return View(pc);
                }
            }
            catch (Exception)
            {
                return View(pc);
            }
        }
        //薪酬
        public ActionResult XinChou()
        {
            return View();
        }
        public async Task<ActionResult> XinChou2()
        {
            List<config_public_char> list = await imk.SelectXC(e=>e.attribute_kind.Equals("薪酬设置"));
            string zhi = JsonConvert.SerializeObject(list);
            return Content(zhi);
        }
        //薪酬添加
        public ActionResult Create2() 
        {
            return View();
        }
        //薪酬添加
        [HttpPost]
        public async Task<ActionResult> Create2(config_public_char pc) 
        {
            try
            {
                pc.attribute_kind = "薪酬设置";
                int result = await imk.AddXC(pc);
                if (result > 0)
                {
                    return RedirectToAction("XinChou");
                }
                else
                {
                    return View(pc);
                }
            }
            catch (Exception)
            {
                return View(pc);
            }
        }

        //删除
        //公共属性设置删除
        public async Task<ActionResult> DeleteXC(int id)
        {
            config_public_char cc = new config_public_char()
            {
                pbc_id = id
            };
            int result = await imk.Del(cc);
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/config_public_char/XinChou'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/config_public_char/XinChou'</script>");
            }
        }
    }
}