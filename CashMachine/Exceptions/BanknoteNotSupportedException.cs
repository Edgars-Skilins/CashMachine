using System.Runtime.Serialization;

namespace CashMachine.Exceptions
{
    [Serializable]
    public class BanknoteNotSupportedException : Exception
    {
        public BanknoteNotSupportedException()
        {
        }

        public BanknoteNotSupportedException(string? message) : base(message)
        {
        }

        public BanknoteNotSupportedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected BanknoteNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}