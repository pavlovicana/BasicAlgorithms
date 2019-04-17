using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = Factorial(num);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static int Factorial(int number)
        {
            int fac = 1;
            while (number > 0)
            {
                fac = number * fac;
                number--;
            }
            return fac;
        }
    }
}
