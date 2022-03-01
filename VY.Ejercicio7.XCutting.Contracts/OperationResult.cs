using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY.Ejercicio7.XCutting.Contracts
{
    public class OperationResult<TResult>
    {
        public OperationResult()
        {
            Errors = new List<ErrorObject>();
        }
        public TResult Result { get; set; }
        public List<ErrorObject> Errors { get; }
        public bool HasErrors => Errors != null && Errors.Any();

    }
}
