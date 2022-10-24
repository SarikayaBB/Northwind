﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Models;

namespace ToDo.Controllers
{
    public static class TaskController
    {
        public static List<Models.Task> GetAllByUser(User user)
        {
            return new List<Models.Task>();
        }
        public static Models.Task Add(User user)
        {
            SqlConnection conn = db.Conn();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Tasks SET UserId =@userId,Subject=@subject,Description=@description,EndDate=@endDate",conn);
                cmd.Parameters.AddWithValue("@userId", user.Id);
                
                
            }
            catch
            {

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }



            return task;
        }

        public static bool Complete(Models.Task task)
        {
            return true;
        }

        public static bool Delete(Models.Task task)
        {
            return true;
        }

        public static Models.Task Update(Models.Task task)
        {
            return task;
        }



    }
}
