using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5] { 6, 7, 8, 9, 10 };
            int[] arr3 = Join(arr1, arr2);

            for(int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine("[{0}] = {1}", i + 1, arr3[i]);
            }
            Console.ReadLine();
        }

        public static int[] Join(int[]arr1, int[]arr2)
        {
            int total = arr1.Length + arr2.Length;
            int[] arr3 = new int[total];

            int i = 0;
            for(i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }

            for(int j = 0; j < arr2.Length;j++)
            {
                arr3[i] = arr2[j];
                i++;
            }
            return arr3;

        }
    }
}
