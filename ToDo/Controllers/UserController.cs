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

        public static Result Add(User user)
        {
            SqlConnection conn = db.Conn();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (UserName,Password,dateModified) VALUES (@userName,@password,GETDATE())", conn);
                cmd.Parameters.AddWithValue("@userName", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
                 string msg = "";
                if (e.Message.ToLower().Contains("duplicate"))
                {
                    msg = "FARKLI ISIM KULLANIN, AYNI ISIMDE KULLANICI OLAMAZ.";
                }

                return new Result { Status = ResultStatus.Fail, Message = msg };
            }
            finally
            {
                conn.Close();
            }
            return new Result { Status = ResultStatus.Success, Message = "Successfully signed up." };

        }
        public static Result Delete(User user)
        {
            SqlConnection conn = db.Conn();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Users SET isDeleted=1, dateModified=GETDATE() WHERE Username=@userName AND Password=@password ", conn);
                cmd.Parameters.AddWithValue("@userName", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);
                // cmd.Parameters.AddWithValue("@id", user.Id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
                return new Result { Status = ResultStatus.Fail, Message = e.Message };
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return new Result { Status = ResultStatus.Success, Message = "SILME ISLEMI BASARILI" };
            
        }
        public static User Update(User user)
        {
            try
            {
                SqlConnection conn = db.Conn();
                SqlCommand cmd = new SqlCommand("UPDATE Users SET UserName=@userName, Password=@password, dateModified=GETDATE() WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@UserName", user.UserName);
                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@password", user.Password);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return user;
        }

    }
}
