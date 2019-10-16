using System;

namespace Negozio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sconto=0;
            double prezzoscontato=0;
            double spesa2;
            Console.WriteLine("Quanto hai speso?");
            double spesa = double.Parse(Console.ReadLine());
            if (spesa <= 300)
            {
                sconto = (spesa / 100) * 10;
                prezzoscontato = spesa - sconto;
                

            }
            else if (spesa > 300)
            {
                spesa2 = spesa - 300;
                sconto = (spesa2 / 100) * 20 + 30;
                prezzoscontato = spesa - sconto;
                
            }
            Console.WriteLine($"La spesa è di {prezzoscontato}, dato lo sconto di {sconto} ");
            Console.ReadLine();

        }
    }
}
