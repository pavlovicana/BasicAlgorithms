using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "this is a string";
            string test = "test";

            char ch1 = original.ElementAt(8);
            string[] split = original.Split(ch1);
            string s1 = " ";
            s1 += split[0] + test + " " + ch1 + split[1];
            Console.WriteLine(s1);
            Console.ReadLine();

        }
    }
}
