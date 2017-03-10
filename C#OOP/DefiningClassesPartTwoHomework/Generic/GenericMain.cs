using System;
using DefiningClasses.Generic;

namespace Generic
{
    public class GenericMain
    {
        public static void Main()
        {
            var student = new GenericList<int>();
            student.Add(5);
            student.Add(2);
            student.Add(3);
            student.Add(1);
            student.Add(4);            
            Console.WriteLine("GenericList: {0}", student.ToString());

            Console.WriteLine("Min element {0}", student.Min());
            Console.WriteLine("Max element {0}", student.Max());

            Console.WriteLine("Index of element 2 before remove 5: {0}", student.FindIndex(2));

            student.RemoveByElement(5);
            Console.WriteLine("GenericList after RemoveByElement(5): {0}", student.ToString());

            Console.WriteLine("Index of element 2 after remove 5: {0}", student.FindIndex(2));
            Console.WriteLine("Index of element 4 before remove element on position 2: {0}", student.FindIndex(4));

            student.RemoveByIndex(2);
           //student.RemoveByIndex(8);
            Console.WriteLine("GenericList after RemoveByIndex(2): {0}", student.ToString());

            Console.WriteLine("Index of element 4 after remove element on position 2: {0}", student.FindIndex(4));


            student.Insert(7, 2);
            Console.WriteLine("GenericList after Insert(7, 2): {0}",  student.ToString());

            Console.WriteLine("Index of element 4 after insert 7: {0}", student.FindIndex(4));

            int elememen = 3;
            Console.WriteLine("Element {0} is on {1} index", elememen, student.FindIndex(elememen));

            student.ClearList();
            Console.WriteLine("GenericList after ClearList: {0}", student.ToString());
        }
    }
}