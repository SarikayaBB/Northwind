using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public int UserId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime endDate { get; set; }
        public bool isActive { get; set; }
        public bool isDeleted { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateModified { get; set; }

        public static implicit operator System.Threading.Tasks.Task(Task v)
        {
            throw new NotImplementedException();
        }
    }
}
