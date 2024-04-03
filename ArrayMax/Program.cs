using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[7] { 2, 4, 6, 8, 2, 12, 22 };
            int max = MaxElem(arr1);
            Console.WriteLine("Maximum element of this array is: {0}",max); -m "Ovo je komentar"
            Console.ReadLine();

        }
        public static int MaxElem(int[]arr)
        {
            int max = arr[0];

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}
