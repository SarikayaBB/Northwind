using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Models;
using Task = ToDo.Models.Task;

namespace ToDo.Controllers
{
    public static class TaskController
    {
        public static List<Models.Task> GetAllByUser(User user)
        {
            List<Task> TList = new List<Task>();
            SqlConnection conn = db.Conn();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tasks WHERE UserId =@userId AND isActive=1 AND isDeleted=0", conn);
                cmd.Parameters.AddWithValue("@userId", user.Id);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    TList.Add(new Models.Task
                    {
                        Id = (int)dr["Id"],
                        isActive = (bool)dr["isActive"],
                        dateCreated = (DateTime)dr["dateCreated"],
                        //  dateModified = (DateTime)dr["dateModified"],
                        Description = dr["Description"].ToString(),
                        endDate = (DateTime)dr["endDate"],
                        Guid = dr["Guid"].ToString(),
                        isDeleted = (bool)dr["isDeleted"],
                        Subject = dr["Subject"].ToString(),
                        UserId = (int)dr["UserId"]
                    });
                }
            }
            catch (Exception e)
            {
                MesajKutusu.Goster("HATA!", e.Message);
            }
            finally
            {
                conn.Close();
            }
            return TList;
        }
        public static Result Add(Task task)
        {
            SqlConnection conn = db.Conn();
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO  Tasks (UserId,Subject,Description,EndDate,dateModified) VALUES (@userId,@subject,@description,@endDate,GETDATE())", conn);
                cmd.Parameters.AddWithValue("@userId", task.UserId);
                cmd.Parameters.AddWithValue("@subject", task.Subject);
                cmd.Parameters.AddWithValue("@description", task.Description);
                cmd.Parameters.AddWithValue("@endDate", task.endDate);
                
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
                MesajKutusu.Goster("HATA!", e.Message);
                return new Result { Message = e.Message, Status = ResultStatus.Fail };
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            MesajKutusu.Goster("BASARILI!", "BASARIYLA EKLEDINIZ! TEBRIKLER.");
            return new Result { Message = "BASARIYLA EKLENDI.", Status = ResultStatus.Success };
        }
        public static Result Complete(Models.Task task)
        {
            SqlConnection conn = db.Conn();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Tasks SET isActive=0 WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", task.Id);
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
                MesajKutusu.Goster("HATA!", e.Message);
                return new Result { Status = ResultStatus.Fail, Message = e.Message };
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            MesajKutusu.Goster("BASARILI!", "TAMAMLANDI! TEBRIKLER");
            return new Result { Status = ResultStatus.Success, Message = "BASARIYLA TAMAMLANDI!" };
        }

        public static Result Delete(Models.Task task)
        {
            SqlConnection conn = db.Conn();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Tasks SET isDeleted=1 WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", task.Id);
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
                MesajKutusu.Goster("HATA!", e.Message);
                return new Result { Message = e.Message, Status = ResultStatus.Fail };
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            MesajKutusu.Goster("SILINDI!", "SILME ISLEMI BASARILI.");
            return new Result { Message = "BASARIYLA SILINDI!", Status = ResultStatus.Success };
        }


        public static Result Update(Models.Task task)
        {
            SqlConnection conn = db.Conn();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Tasks SET Description=@description,Subject=@subject,EndDate=@endDate WHERE Id=@id", conn);
                // cmd.Parameters.AddWithValue("@userId", task.UserId);
                cmd.Parameters.AddWithValue("@description", task.Description);
                cmd.Parameters.AddWithValue("@id", task.Id);
                cmd.Parameters.AddWithValue("@subject", task.Subject);
                cmd.Parameters.AddWithValue("@EndDate", "2000.10.10");
                cmd.Parameters.AddWithValue("@dateModified", DateTime.Now);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                MesajKutusu.Goster("HATA!", e.Message);
                return new Result { Status = ResultStatus.Fail, Message = e.Message };
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            MesajKutusu.Goster("BASARIYLA EKLENDI.", "BASARILI!");
            return new Result { Message = "BASARIYLA EKLENDI.", Status = ResultStatus.Success };
        }
    }
}
