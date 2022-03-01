using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY.Ejercicio7.XCutting.Contracts
{
    public class ErrorObject
    {
        public ErrorObject(string message,
        int code,
        Exception exception = null)
        {
            Code = code;
            Message = message;
            Exception = exception;
        }

        public Exception Exception { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
