using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SoTietKiemLui()
        {
            ViewBag.Message = "STK.";

            return View();
        }
        public ActionResult LyDoLuaChon()
        {
            ViewBag.Message = "Ly Do Lua Chon.";

            return View();
        }
        public ActionResult PhuongThucThanhToan()
        {
            ViewBag.Message = "PhuongThucThanhToan.";

            return View();
        }
    }
}