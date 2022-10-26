using System;
using System.Collections.Generic;

namespace ToDoEF.Models
{
    public partial class Task
    {
        public int Id { get; set; }
        public string Guid { get; set; } = null!;
        public int UserId { get; set; }
        public string Subject { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime EndDate { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
