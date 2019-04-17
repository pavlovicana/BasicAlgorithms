using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Today is a beautiful day.";
            Console.WriteLine("Count number of words in string.");
            int count = 0;

            for(int i = 0; i < s1.Length; i++)
            {
                if(s1[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
