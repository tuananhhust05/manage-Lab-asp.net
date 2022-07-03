using Model13.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model13
{
    public class CategoryModel
    {
        private OnlineShopModelContext context = null;  // tạo contructor
        public CategoryModel()  // contructor
        {
            context = new OnlineShopModelContext();

        }

        public List<Category> ListAll()                //List<Category> danh sách gồm các dòng dữ liệu 
        {
            var list = context.Database.SqlQuery<Category>("Sp_Category_ListAll").ToList();// trả về dòng 
            return list;
        }
    }
}
