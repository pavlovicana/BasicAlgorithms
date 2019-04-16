using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_char
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Today is a good day";
            int count = ReturnNumber(input);
            Console.WriteLine(count);
            Console.ReadLine();

        }
        public static int ReturnNumber(string input)
        {
            string lower = input.ToLower();
            char[] array = lower.ToCharArray();
            int counter = 0;
 

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == 'o')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
