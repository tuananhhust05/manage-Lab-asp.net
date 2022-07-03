using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace onlineshow5.Areas.admin.Controllers
{   
    [Authorize] // bắt buộc phải authorize=> tự động check login
    public class homeAdminController : Controller
    {
        // GET: admin/homeAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}