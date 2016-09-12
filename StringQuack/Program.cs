using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringQuack
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World";
            Console.WriteLine(message.Quack());
        }
    }

    public static class StringExtensions
    {
        public static string Quack(this string self)
        {
            return self + " (quack)";
        }
    }

}
