using System;
using System.Runtime.Serialization;

namespace DAL
{
    [Serializable]
    internal class ExceptionAlreadyExist : Exception
    {
        public ExceptionAlreadyExist()
        {
        }

        public ExceptionAlreadyExist(string message) : base(message)
        {
        }

        public ExceptionAlreadyExist(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionAlreadyExist(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}