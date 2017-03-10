namespace Problem03RangeExceptions
{
    using System;
    using Contracts;

    public class InvalidRangeException<T> : ApplicationException, IInvalidRangeException<T>
    {
        public InvalidRangeException(string errorMessage, T startRangeDefinition, T endRangeDefinition)
        {
            this.ErrorMessage = errorMessage;
            this.StartRangeDefinition = startRangeDefinition;
            this.EndRangeDefinition = endRangeDefinition;
        }

        public string ErrorMessage { get; set; }
        public T StartRangeDefinition { get; set; }
        public T EndRangeDefinition { get; set; }
    }
}