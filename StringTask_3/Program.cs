using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Welcome to w3resource.com ";
            int letter = 0;
            int otherchars = 0;
            int numbers = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if ((s1[i] >= 'a' && s1[i] <= 'z') || (s1[i] >= 'A' && s1[i] <= 'Z'))
                {
                    letter++;
                }
                else if (s1[i] >= '0' && s1[i] <= '9')
                {
                    numbers++;
                }
                else
                {
                    otherchars++;
                }
            }
            Console.WriteLine(letter);
            Console.WriteLine(numbers);
            Console.WriteLine(otherchars);
            Console.ReadLine();

        }
    }
}
