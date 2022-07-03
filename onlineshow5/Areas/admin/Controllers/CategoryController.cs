using Model13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace onlineshow5.Areas.admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: admin/Category
        public ActionResult Index()
        {
            var iplCate = new CategoryModel(); // khai báo 
            var model = iplCate.ListAll(); // dùng lisAll trả về thằng Model để truyền vào view 
            return View(model); // model được listAll điền đầy => đưa vào ,model vào view, nó chính là thằng model khai báo ở đầu view 
        }

        // GET: admin/Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/Category/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: admin/Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: admin/Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: admin/Category/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Table()
        {
            FormsAuthentication.SignOut(); // phương thức signout được fix sẵn => đăng xuất => dùng để chuyển trang vẫn ok 
            return RedirectToAction("Index", "Category");  // trả ngược về page login
        }

    }
}
