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
            int currentYears = int.Parse(Console.ReadLine());
            DateTime afterTenYears = DateTime.Now.AddYears(10);
            int result = afterTenYears.Year - currentYears;

            Console.WriteLine(result);
        }
    }
}
