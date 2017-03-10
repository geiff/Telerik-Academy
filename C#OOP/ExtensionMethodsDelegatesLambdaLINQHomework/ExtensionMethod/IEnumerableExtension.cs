using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethod
{
    public static class IEnumerableExtension
    {
        public static T SumNum<T>(this IEnumerable<T> num)
        {
            T sum = default(T);

            foreach (var n in num)
            {
               sum = (dynamic)sum + n;
            }

            return sum;
        }

        public static T ProductNum<T>(this IEnumerable<T> num)
        {
            T prod = (dynamic)1;

            foreach (var n in num)
            {
                prod = (dynamic)prod * n;
            }

            return prod;
        }

        public static T MinNum<T>(this IEnumerable<T> num)
        {
            return num.Min();
        }

        public static T MaxNum<T>(this IEnumerable<T> num)
        {
            return num.Max();
        }

        public static T AverageNum<T>(this IEnumerable<T> num)
        {
            T sum = default(T);

            foreach (var n in num)
            {
                sum = (dynamic)sum + n;
            }

            return (dynamic)sum / num.Count();
        }
    }
}