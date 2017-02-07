using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            for (int i = 2; i > -102; i *= -1)
            {
                Console.WriteLine(i);
                i = i + x;
                x *= -1;
            }
        }
    }
}
