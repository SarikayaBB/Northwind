using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoEF.Models;

namespace ToDoEF
{
    public static class TaskController
    {
        public static readonly ToDoContext context = new ToDoContext();
        public static List<Models.Task> GetAllByUser(Models.User user)
        {
            return context.Tasks.Where(t => t.UserId == user.Id && t.IsDeleted == false && t.IsActive == true).ToList<Models.Task>();
        }
        public static Result Add(Models.Task task)
        {
            context.Tasks.Add(task);
            context.SaveChanges();
            return new Result { Status = ResultStatus.Success, Message = "BASARIYLA EKLENDI." };
        }
        public static Result Complete(Models.Task task)
        {
            task.IsActive = false;
            task.DateModified = DateTime.Now;
            context.Tasks.Update(task);
            context.SaveChanges();

            return new Result { Status = ResultStatus.Success, Message = "BASARIYLA TAMAMLANDI." };
        }
    }
}
