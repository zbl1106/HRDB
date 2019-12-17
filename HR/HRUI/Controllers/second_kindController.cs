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
    //客户化设置控制器:二级机构设置
    public class second_kindController : Controller
    {
        HRContext hr = new HRContext();
        // GET: Client
        //属性注入
        public Iconfig_file_second_kindBLL isk { get; set; }
        public Iconfig_file_first_kindBLL ifk { get; set; }
        // GET: second_kind
        public ActionResult Index()
        {
            return View();
        }

        //查询
       public async Task<ActionResult> Index2()
        {
            List<config_file_second_kind> list = await isk.CSKSelect();
            string zhi = JsonConvert.SerializeObject(list);
            return Content(zhi);
        }

        //新增
        public async Task<ActionResult> Create()
        {
            ////下拉框
            ////在数据库获取数据
            //var codebase = hr.Econfig_file_first_kind.AsNoTracking().ToList().Select(c => new SelectListItem { Text = c.first_kind_name, Value = c.ffk_id.ToString() }).ToList();
            ////将codebase的数据封装到selectlist中，要制定生成下拉框选项的value和text属性
            //SelectList sellist = new SelectList(codebase, "ID", "Name");
            ////将sellist复制给viewBag,用于在视图中显示
            //ViewData["list"] = codebase;
            //return View();

            List<config_file_first_kind> list2 = await ifk.CFKSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var item in list2)
            {
                list.Add(new SelectListItem { Text = item.first_kind_name,Value=item.first_kind_id.ToString()+","+item.first_kind_name });
            }
            ViewData["list"] = list;
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Create(config_file_second_kind ck)
        {
            try
            {
                string[] sz = ck.first_kind_name.Split(',');
                ck.first_kind_id = sz[0];
                ck.first_kind_name = sz[1];
                int result = await isk.CSKAdd(ck);
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
            config_file_second_kind cc = new config_file_second_kind()
            {
                fsk_id = id
            };
            int result = await isk.CSKDel(cc);
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/second_kind/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/second_kind/Index'</script>");
            }
        }

        //修改
        public async Task<ActionResult> Edit( int id)
        {
            List<config_file_first_kind> list2 = await ifk.CFKSelect();
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var item in list2)
            {
                list.Add(new SelectListItem { Text = item.first_kind_name, Value = item.first_kind_id.ToString() + "," + item.first_kind_name });
            }
            ViewData["list"] = list;

            Econfig_file_second_kind st = hr.Econfig_file_second_kind.AsNoTracking().Where(e => e.fsk_id.Equals(id)).FirstOrDefault();
            config_file_second_kind st2 = new config_file_second_kind()
            {
                fsk_id=st.fsk_id,
                first_kind_id=st.first_kind_id,
                first_kind_name=st.first_kind_name,
                second_kind_id=st.second_kind_id,
                second_kind_name=st.second_kind_name,
                second_salary_id=st.second_salary_id,
                second_sale_id=st.second_sale_id
            };
            return View(st2);
        }

        [HttpPost]
        public async Task<ActionResult> Edit( config_file_second_kind st)
        {
            try
            {
                string[] sz = st.first_kind_name.Split(',');
                st.first_kind_id = sz[0];
                st.first_kind_name = sz[1];
                string[] ps = new string[] { "fsk_id", "first_kind_id", "first_kind_name", "second_kind_id", "second_kind_name", "second_salary_id", "second_sale_id" };
                int result = await isk.CSKUpdate(st,ps);
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(st);
                }
            }
            catch (Exception)
            {
                return View(st);
            }
        }

    }
}