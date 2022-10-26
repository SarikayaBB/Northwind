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
    }
}
