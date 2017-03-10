using System.Text;

namespace ExtensionMethod
{
    public static class StringBuilderSubString
    {
        public static StringBuilder Substring(this StringBuilder subStr, int index, int length)
        {
            StringBuilder resultSubStr = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                resultSubStr.Append(subStr[i]);
            }

            return resultSubStr;
        }
    }
}