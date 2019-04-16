using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[6] { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = new int[6] { 1, 2, 3, 4, 11, 6};
            Console.WriteLine(IsItEqual(arr1, arr2));
            Console.ReadLine();           
        }

        public static bool IsItEqual(int[]arr1, int[]arr2)
        {
            bool check = true;

            for(int i = 0; i < arr1.Length;i++)
            {
                if(arr1.Length == arr2.Length)
                {
                    if(arr1[i] == arr2[i])
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                else
                {
                    check = false;
                }
            }

            if(!check)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
