using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 1, 3, 5, 8, 10, 12, 7 };
            EvenOrOdd(arr);
            Console.ReadLine();

        }
        public static void EvenOrOdd(int[]arr)
        {
            bool choose = true;

            do
            {
                Console.WriteLine("Input 1 for even numbers.");
                Console.WriteLine("Input 2 for odd numbers.");
                int opcija = Convert.ToInt32(Console.ReadLine());
               
                switch (opcija)
                {
                    case 1:
                        Console.WriteLine("Even numbers of an array");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] % 2 == 0)
                            {
                                Console.WriteLine(arr[i]);
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Odd numbers of an array");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] % 2 != 0)
                            {
                                Console.WriteLine(arr[i]);
                            }
                        }
                        break;
                }
                Console.WriteLine("Do you want to continue? input y for [yes] n for [no]");
                string con = Console.ReadLine();
                if(con.ToLower()=="y")
                {
                    choose = true;
                }
                else if(con.ToLower()=="n")
                {
                    choose = false;
                }
            } while (choose);
        }
    }
}
