using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //swap two integers
            int a = 12;
            int b = 32;
            int temp = 0;

            temp = b;
            b = a;
            a = temp;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            //without using temp variable

            int x = 2;
            int y = 8;

            x = x + y;
            y = x - y;
            x = x -y;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.ReadLine();






        }
    }
}
