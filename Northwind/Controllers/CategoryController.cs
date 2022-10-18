using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Controllers
{
    public class CategoryController
    {
        public static void Add(Category category)
        {
            SqlConnection conn = new SqlConnection("SERVER=.\\SQLEXPRESS;User=sa;Password=123456;Database=Northwind");
            SqlCommand cmd = new SqlCommand("Insert INTO Categories (CategoryName,Description) values(@categoryName,@description)", conn);
            cmd.Parameters.AddWithValue("categoryName", category.CategoryName);
            cmd.Parameters.AddWithValue("description", category.Description);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
