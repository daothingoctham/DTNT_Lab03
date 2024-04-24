using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson03.DTNT.Controllers
{
    public class DTNTstudentController : Controller
    {
        // GET: DTNTstudent
        public ActionResult Index()
        {
            ViewData["msg"] = "View Data- ĐÀO NGỌC THẮM";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult StudentList()
        {
            ViewBag.titleName = "Danh sách học viên - Đào Ngọc Thắm";
            string[] names = { "Tạ Hồng", "Ngọc Thắm", "Diễm Hương", "Kim Oanh" };
            ViewBag.list = names;
            var obj = new
            {
                ID = 100,
                Name = "Ngọc Thắm",
                Age = 20
            };
            ViewBag.student = obj;
            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}