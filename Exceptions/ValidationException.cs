using System;

namespace OnlineMarket.Exceptions
{
    public class ValidationException : Exception
    {
        public string Log { get; }
        public ValidationException(string message, string json) : base(message)
        {
            Log = json;
        }
    }
}
