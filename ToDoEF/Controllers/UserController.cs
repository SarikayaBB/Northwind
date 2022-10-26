using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ToDoEF.Models;
using Task = ToDoEF.Models.Task;

namespace ToDoEF.Controllers
{
    public static class UserController
    {
        public static readonly ToDoContext context = new ToDoContext();
        public static User Login(User user)
        {

            return context.Users.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password && u.IsActive == true && u.IsDeleted == false);




        }

    }
}
