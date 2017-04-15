using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = '\u0048';

            Console.WriteLine("{0}'s unicode number is {1:x}", letter, (int)letter);
        }
    }
}
