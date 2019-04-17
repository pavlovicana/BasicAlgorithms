using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "This is a string to be copied.";
            string[] s2 = new string[s1.Length];

            int i = 0;
            int count = 0;

            for(i = 0; i < s1.Length; i++)
            {
                string temp = s1[i].ToString();
                s2[i] = temp;
                count++;
            }
            Console.WriteLine(s1);
            Console.WriteLine(string.Join("", s2));
            Console.WriteLine(count);
            Console.ReadLine();

        }
    }
}
