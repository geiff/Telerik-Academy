namespace Problem03RangeExceptions.Contracts
{
    using System;

    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        DateTime BirthDate { get; set; }
    }
}