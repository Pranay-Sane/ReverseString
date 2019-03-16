using System;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("hello"));
        }

        static string ReverseString(string str)
        {
            int len = str.Length;
            if(len == 1)
            {
                return str;
            }
            return str[len - 1] + ReverseString(str.Substring(0, len - 1));
        }
    }
}
