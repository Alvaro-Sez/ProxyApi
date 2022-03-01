using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY.Ejercicio7.XCutting.Contracts
{
    public static class OperationResultExtensions
    {
        public static OperationResult<TResult> AddResult<TResult>(
            this OperationResult<TResult> operationResult,
            TResult result)
        {
            if (operationResult == null)
                throw new ArgumentNullException(nameof(operationResult),
                    "builderContext cannot be null");
            operationResult.Result = result;
            return operationResult;
        }

        public static OperationResult<TResult> AddResultWithError<TResult>(
            this OperationResult<TResult> operationResult,
            TResult result,
            string errorMessage,
            int errorCode,
            Exception exception = null)
        {
            if (operationResult == null)
                throw new ArgumentNullException(nameof(operationResult),
                    "builderContext cannot be null");
            operationResult.Result = result;
            operationResult.Errors.Add(new ErrorObject(errorMessage, errorCode, exception));
            return operationResult;
        }

        public static OperationResult<TResult> AddResultWithError<TResult>(
            this OperationResult<TResult> operationResult,
            TResult result,
            ErrorObject errorResult)
        {
            if (operationResult == null)
                throw new ArgumentNullException(nameof(operationResult),
                    "builderContext cannot be null");
            operationResult.Result = result;
            operationResult.Errors.Add(errorResult);
            return operationResult;
        }

        public static OperationResult<TResult> AddError<TResult>(
            this OperationResult<TResult> operationResult,
            string errorMessage,
            int errorCode,
            Exception exception = null)
        {
            if (operationResult == null)
                throw new ArgumentNullException(nameof(operationResult),
                    "builderContext cannot be null");
            operationResult.Errors.Add(new ErrorObject(errorMessage, errorCode, exception));
            return operationResult;
        }

        public static OperationResult<TResult> AddError<TResult>(
            this OperationResult<TResult> operationResult,
            ErrorObject errorResult)
        {
            if (operationResult == null)
                throw new ArgumentNullException(nameof(operationResult),
                    "builderContext cannot be null");
            operationResult.Errors.Add(errorResult);
            return operationResult;
        }

        public static OperationResult<TResult> AddErrors<TResult>(
            this OperationResult<TResult> operationResult,
            IEnumerable<ErrorObject> validationErrors)
        {
            if (operationResult == null)
                throw new ArgumentNullException(nameof(operationResult),
                    "builderContext cannot be null");
            operationResult.Errors.AddRange(validationErrors);
            return operationResult;
        }

    }
}
