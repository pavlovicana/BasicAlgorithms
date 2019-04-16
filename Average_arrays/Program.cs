using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[6] { 7, 12, 22, 77, 2, 6 };
            int[] arr2 = new int[6] { 7, 12, 22, 77, 2, 6 };
            Average(arr1, arr2);
            Console.ReadLine();        

        }
        public static void Average(int[]arr1, int[]arr2)
        {
            int av1 = 0;
            int av2 = 0;
            int sum1 = 0;
            int sum2 = 0;

            for(int i = 0; i < arr1.Length; i++)
            {
                sum1 += arr1[i];
            }
            av1 = sum1 / arr1.Length;
            Console.WriteLine("Average of the first array is: {0}", av1);

            for (int i = 0; i < arr2.Length; i++)
            {
                sum2 += arr2[i];
            }
            av2 = sum2 / arr2.Length;
            Console.WriteLine("Average of the second array is: {0}", av2);

        }
    }
}
