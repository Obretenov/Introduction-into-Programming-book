using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char c = '\u00A9';

            Console.WriteLine("    " + c);
            Console.WriteLine("   " + c + " " + c);
            Console.WriteLine("  " + c + "   " + c);
            Console.WriteLine(" " + c + "     " + c);
            Console.WriteLine(c + " " + c + " " + c + " " + c + " " + c);
        }
    }
}
