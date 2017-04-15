using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = 0.000001m;
            decimal secondNum = 0.000001m;
            decimal result = firstNum + secondNum;

            Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, result);
        }
    }
}
