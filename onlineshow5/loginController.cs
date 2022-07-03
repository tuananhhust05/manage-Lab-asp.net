
using Model12;
using onlineshow5.Areas.admin.CODE;
using onlineshow5.Areas.admin.Model;
using System.Web.Mvc;

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
            var result = new AccountModel().login(model.UserName, model.password);
            if(result && ModelState.IsValid) // 2dk thỏa mản 
            {   // ý này là đăng nhập thành công 
                // nếu thành công ta cần set một cái sesion cho nó => tạo folder 

                SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                // model là đối tượng truyền vào của hàm mẹ, trong model có thuộc tính UserName=> phù hợp với thuộc tính truyền vào của setsesion 

                return RedirectToAction("Index", "Home"); // giống như mở trang chủ => chuyển quyền đến đó 
                // hai thằng trong ngoặc là 2 cái controller 
            } // thằng Model State thuộc ModelState DictionaryController ( thư viện )
            
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng "); // thông báo mặc định của thư viện 
            };
            return View(model); // trả về 1 cái view => quan hệ của front end và backend
        }
            
    }

}