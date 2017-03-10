namespace Problem03RangeExceptions
{
    using System;

    public class RangeExceptionsMain
    {
        static void Main()
        {
            Person pesho = new Person("Pesho", -20, new DateTime(1700, 12, 10));
            Person gosho = new Person("Gosho", 25, new DateTime(1985, 07, 12));
            Console.WriteLine(gosho);
        }
    }
}