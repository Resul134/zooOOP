using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooOOP
{
    class Hest

    {
        // hestens navn?
        public String navn;

        //maxhastighed måles i km/t
        public double MaxHastighed;

        //fødselsår
        public int Year;

        public Hest()
        {
            Console.WriteLine("Indtast venligst hestenavn #1:");
            navn = Console.ReadLine();
            Console.WriteLine("Hestens fødselsår?");
            Year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvor hurtig er du");
            MaxHastighed= Convert.ToDouble(Console.ReadLine());

        }

        private void Eat()
        {
            Console.WriteLine("Gnaske gnaske...");
        }

        public void Run()
        {
            if (Year - 2018 <= 2)
            {
                Console.WriteLine("weeeeeeeeeeeeeeee");
            }
            Console.Write("Wrinske wrinske");
            Console.WriteLine(" - med " + MaxHastighed + " km/t");
            Console.WriteLine("Wrinske-hilsen " + navn);
            Console.WriteLine("Jeg er " + (2018 - Year) + "år gammel");
            Eat();
        }
    }
}