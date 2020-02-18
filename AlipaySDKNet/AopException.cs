using System;
using System.Runtime.Serialization;

namespace Aop.Api
{
    /// <summary>
    /// AOP客户端异常。
    /// </summary>
    public class AopException : Exception
    {
        public AopException()
        {
        }

        public AopException(string message)
            : base(message)
        {
        }

        protected AopException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public AopException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public AopException(string errorCode, string errorMsg)
            : base(errorCode + ":" + errorMsg)
        {
            this.ErrorCode = errorCode;
            this.ErrorMsg = errorMsg;
        }

        public string ErrorCode { get; set; }

        public string ErrorMsg { get; set; }
    }
}
