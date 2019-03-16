using System;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("hello"));
        }

        static string ReverseString(string str)
        {
            string reverse = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str.Substring(i, 1);
            }
            return reverse;
        }
    }
}
