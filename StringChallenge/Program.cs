using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string unetiTekst = "Danas je divan dan.";
            Console.WriteLine("Unesi lokaciju cara koji zelis da ti se ispise na konzoli.");
            int lokacija = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(unetiTekst[lokacija - 1]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Lokacija ne odgovara duzini naseg tekta." + e);
            }
            Console.ReadLine();
        }


    }

}
