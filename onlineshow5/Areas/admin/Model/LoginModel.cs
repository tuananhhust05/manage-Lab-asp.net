using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace onlineshow5.Areas.admin.Model
{
    public class LoginModel  // để truyền từ view lên và trả về view => có 3 tham số 
    {   
        [Required]  // thuộc tính bắt buộc với 3 biến này 
        public string UserName { get; set; }

        public string password { get; set; }
        public bool RemmemberMe { get; set; }
    }
}