namespace Problem03RangeExceptions.Contracts
{
    interface IInvalidRangeException<T>
    {
        string ErrorMessage { get; set; }
        T StartRangeDefinition { get; set; }
        T EndRangeDefinition { get; set; }
    }
}