using Model13;
using onlineshow5.Areas.admin.CODE;
using onlineshow5.Areas.admin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace onlineshow5.Areas.admin.Controllers
{
    public class loginController : Controller
    {
        // GET: admin/login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]  // Validate => ở trên server sinh ra 1 cái token, ở dưới client cũng có 1 cái token tương tự 
      
        // request và response đều đặn 
        public ActionResult Index(LoginModel model)  // đây như kiểu ta kết nối front end và backend vậy 
        {
            //var result = new AccountModel().login(model.UserName, model.password);  // comment vào vì dùng customermembership
            if(Membership.ValidateUser(model.UserName,model.password) && ModelState.IsValid) // 2dk thỏa mản => thuộc 
            {    // nếu thành công ta cần set một cái sesion cho nó => tạo folder


                // SessionHelper.SetSession(new UserSession() { UserName = model.UserName }); dùng customer 
                // model là đối tượng truyền vào của hàm mẹ, trong model có thuộc tính UserName=> phù hợp với thuộc tính truyền vào của setsesion 

                FormsAuthentication.SetAuthCookie(model.UserName, model.RemmemberMe);// set ô checkBox 
                return RedirectToAction("Index", "homeAdmin"); // giống như mở trang chủ => chuyển quyền đến đó   => chuyển quyền đến homeAdmin mới đúng => đã rât đau đầu về vấn đề này.
                 
            } // thằng Model State thuộc ModelState DictionaryController ( thư viện )
            
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng "); // thông báo mặc định của thư viện 
            };
            return View(model); // trả về view cũ 
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut(); // phương thức signout được fix sẵn => đăng xuất 
            return RedirectToAction("Index", "login");
        }
    }

}