using System.Runtime.Serialization;

namespace CashMachine.Exceptions
{
    [Serializable]
    public class IncorrectAmountException : Exception
    {
        public IncorrectAmountException()
        {
        }

        public IncorrectAmountException(string? message) : base(message)
        {
        }

        public IncorrectAmountException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IncorrectAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}