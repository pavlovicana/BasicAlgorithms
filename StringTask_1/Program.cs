using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Welcome to my GitHub profile";
            int max = 0;
            int ascii = 0;
            int[] arrchar = new int[255];

            for (int i = 0; i < 255; i++)
            {
                arrchar[i] = 0;
            }
            for (int i = 0; i < s1.Length; i++)
            {
                ascii = (int)s1[i];
                arrchar[ascii] += 1;
            }
            for (int i = 0; i < 255; i++)
            {
                if (i != 32)
                {
                    if (arrchar[i] > arrchar[max])
                    {
                        max = i;
                    }
                }
            }
            Console.WriteLine("Character max is {0} and appears {1} times.", (char)max, arrchar[max]);
            Console.ReadLine();


        }
    }
}
