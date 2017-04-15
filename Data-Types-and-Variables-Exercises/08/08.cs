using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            object fullString = firstString + " " + secondString + "!";
            string convertObject = (string)fullString;

            Console.WriteLine(convertObject);
        }
    }
}
