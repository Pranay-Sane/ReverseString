using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution4
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
            foreach(char item in str.Reverse())
            {
                reverse += item;
            }
            return reverse;
        }
    }
}
