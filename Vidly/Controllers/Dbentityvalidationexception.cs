using System;
using System.Runtime.Serialization;

namespace Vidly.Controllers
{
    [Serializable]
    internal class Dbentityvalidationexception : Exception
    {
        public Dbentityvalidationexception()
        {
        }

        public Dbentityvalidationexception(string message) : base(message)
        {
        }

        public Dbentityvalidationexception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Dbentityvalidationexception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}