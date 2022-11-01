using System;
using System.Runtime.Serialization;

namespace Core.Models.Exceptions
{
    public class InvalidNumberOfInstallmentsException : Exception
    {
        public InvalidNumberOfInstallmentsException() : base("Invalid number of installments.")
        {
        }

        public InvalidNumberOfInstallmentsException(string message) : base(message)
        {
        }

        public InvalidNumberOfInstallmentsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidNumberOfInstallmentsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
