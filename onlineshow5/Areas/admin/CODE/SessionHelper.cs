using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlineshow5.Areas.admin.CODE
{
    public class SessionHelper
    {
        public static void SetSession(UserSession session)  // phương thức có tác dụng nhận 1 UserSession
        {
            HttpContext.Current.Session["loginSession"] = session;  // cho sesion login bằng với session truyền vào 
        } // nhận thông tin từ User và set session
        public static UserSession GetSession()
        {
            var sesion = HttpContext.Current.Session["loginSession"];  // lấy thông tin từ phương thức trên 
            if (sesion == null)
                return null;
            else
            {
                return sesion as UserSession;   // nếu không rông thì trả về  1 session dạng UserSession
            }
        }
    }
}