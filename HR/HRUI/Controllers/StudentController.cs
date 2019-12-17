using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using HRIBLL;
using HRModel;
using Newtonsoft.Json;
using HREFEntity;
namespace HRUI.Controllers
{
    public class StudentController : Controller
    {
        HRContext hr = new HRContext();
        //属性注入
        public IStudentBLL IStudentBLL { get; set; }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Index2() 
        {
            List<Student> list = await IStudentBLL.StudentSelect();
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
        public async Task<ActionResult> Create(Student st) 
        {
            try
            {
             int result=  await IStudentBLL.StudentAdd(st);
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

        //修改
        public ActionResult Edit(int id)
        {
            
            EStudent st = hr.EStudent.AsNoTracking().Where(e => e.Id.Equals(id)).FirstOrDefault();
            Student st2 = new Student() 
            {
             Id=st.Id,
             Name=st.Name,
             Age=st.Age
            };
            return View(st2);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, Student st)
        {
            try
            {
                string[] ps = new string[] { "Name", "Id", "Age" };
                int result = await IStudentBLL.StudentUpdate(st, ps);
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

        //删除
        public async Task<ActionResult> Delete(int id)
        {
            Student st = new Student() 
            {
              Id=id
            };
           int result=await  IStudentBLL.StudentDel(st);
            if (result > 0)
            {
                return Content("<script>alert('删除成功');window.location.href='/Student/Index'</script>");
            }
            else
            {
                return Content("<script>alert('删除失败');window.location.href='/Student/Index'</script>");
            }
        }



        }
}