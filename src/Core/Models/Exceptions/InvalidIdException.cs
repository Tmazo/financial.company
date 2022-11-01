using System;
using System.Runtime.Serialization;

namespace Core.Models.Exceptions
{
    public class InvalidIdException : Exception
    {
        public InvalidIdException() : base("Invalid number of id.")
        {
        }

        public InvalidIdException(string message) : base(message)
        {
        }

        public InvalidIdException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidIdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
