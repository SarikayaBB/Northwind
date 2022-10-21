using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class Result
    {
        public ResultStatus Status { get; set; }
        public string Message { get; set; }

    }
    public enum ResultStatus
    {
        Success = 1,
        Fail = 0
    }
}
