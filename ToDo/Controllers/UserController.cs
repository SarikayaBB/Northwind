using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Controllers
{
    public static class UserController
    {
        public static bool Login(User user)
        {
            SqlConnection conn = db.Conn();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @userName AND Password = @Password", conn);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            conn.Open();
            int i = (int)cmd.ExecuteScalar();
            /* SqlDataReader dr = cmd.ExecuteReader();*/
            conn.Close();

            if (i == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static List<User> GetAll()
        {
            return new List<User>();
        }

        public static User Add(User user)
        {
            return user;

        }
        public static bool Delete(User user)
        {
            return true;
        }
        public static User Update(User user)
        {
            return user;
        }

    }
}
