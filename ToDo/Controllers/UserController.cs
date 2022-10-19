using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ToDo.Controllers
{
    public static class UserController
    {
        public static User Login(User user)
        {
            SqlConnection conn = db.Conn();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password AND isActive=1 AND isDeleted=0", conn);
            cmd.Parameters.AddWithValue("@UserName", user.UserName);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            /* SqlDataReader dr = cmd.ExecuteReader();*/
            dr.Read();
            if (dr.HasRows)
            {
                return new User
                {
                    Id = (int)dr["Id"],
                    UserName = (string)dr["UserName"],
                    Guid = (string)dr["Guid"],
                    dateCreated = (DateTime)dr["dateCreated"],
                    Password = (string)dr["Password"],
                    isActive = (bool)dr["isActive"],
                    dateModified = (DateTime)dr["dateModified"],
                    isDeleted = (bool)dr["isDeleted"],
                    isAdmin = (bool)dr["isAdmin"]
                };
            }
            else
            {
                return new User { Id = 0 };
            }

        }
        public static List<User> GetAll()
        {
            SqlConnection conn = db.Conn();
            List<User> list = new List<User>();
            SqlCommand cmd = new SqlCommand("Select * From Users WHERE isActive =1 AND isDeleted=0", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new User
                {
                    Id = (int)dr["Id"],
                    UserName = (string)dr["UserName"],
                    Guid = (string)dr["Guid"],
                    dateCreated = (DateTime)dr["dateCreated"],
                    Password = (string)dr["Password"],
                    isActive = (bool)dr["isActive"],
                    dateModified = (DateTime)dr["dateModified"],
                    isDeleted = (bool)dr["isDeleted"],
                    isAdmin = (bool)dr["isAdmin"]
                });
            }
            conn.Close();
            return list;
        }

        public static User Add(User user)
        {
            /*  SqlConnection conn = db.Conn();
              SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserName,Password) VALUES (@UserName,@Password)", conn);
              cmd.Parameters.AddWithValue("@UserName", user.UserName);
              cmd.Parameters.AddWithValue("@Password", user.Password);
              conn.Open();
              cmd.ExecuteNonQuery();
              /* SqlDataReader dr = cmd.ExecuteReader();
              conn.Close();*/
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
