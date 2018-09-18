using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Kat k = new Kat();
            k.navn = "Molly";

            Dyr dyr = new Dyr();
            dyr.Tam = true;
            dyr.Tam = false;
            Console.WriteLine(dyr.Tam);
            // Create instance of Hest
            Hest minHest = new Hest();
            Hest MinAndenHest = new Hest();
            // Use instance of Hest
            Console.WriteLine("Indtast venligst hestenavn #1");
            minHest.navn = Console.ReadLine();
            Console.WriteLine("Hestens fødseslsår");
            minHest.Year = Convert.ToInt32(Console.ReadLine());

            minHest.navn = "Muhammed";
            minHest.MaxHastighed = 3.14159;
            minHest.Run();

            Console.WriteLine("Indtast venligst hestenavn #2");
            Console.Write("Hvor gammel er jeg?");
            Console.WriteLine();
            MinAndenHest.navn = "Bentley";
            MinAndenHest.MaxHastighed = MinAndenHest.MaxHastighed *3;
            Console.WriteLine("Hestens fødseslsår");
            MinAndenHest.Year = Convert.ToInt32(Console.ReadLine());
        }
    }
}
