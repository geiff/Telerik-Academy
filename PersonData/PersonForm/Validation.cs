using System;

namespace PersonForm
{
    public class Validation
    {
        public static bool ValidationForm(string name, string date, string email, string phoneNumber)
        {

            if (name == String.Empty || date == String.Empty || email == String.Empty || phoneNumber == String.Empty)
            {
                return false;
            }

            return true;
        }

        public static string ValidationString(string name, string date, string email, string phoneNumber)
        {
            if (name == String.Empty)
            {
                return "Please input name";
            }
            else if (date == String.Empty)
            {
                return "Please input date";
            }
            else if (email == String.Empty)
            {
                return "Please input email";
            }

            return "Please input phone number";
        }
    }
}