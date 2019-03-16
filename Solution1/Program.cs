using System;

namespace Solution1
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
                reverse += str[i];
            }
            return reverse;
        }
    }
}
