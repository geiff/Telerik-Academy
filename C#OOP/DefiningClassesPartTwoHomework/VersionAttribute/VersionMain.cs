using System;

namespace VersionAttribute
{
    [Version("2.11")]
    public class VersionMain
    {
        static void Main()
        {
            Type type = typeof(VersionMain);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("This class version attribute is {0}. ", attr.Version);
            }
        }
    }
}