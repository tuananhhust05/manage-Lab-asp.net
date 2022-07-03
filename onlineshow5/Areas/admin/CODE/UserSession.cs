using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlineshow5.Areas.admin.CODE // class để lưu thông tin session 
{   

    [Serializable] // để luư được thông tin session vào session ta cần  thuộc tính này 
    public class UserSession
    {
        public string UserName { get; set; } // tuần tự hóa nó ra nhị phân => cần 1 lớp để set ghép cho session này 

    }
}