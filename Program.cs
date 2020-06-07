using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_TR1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Zahl1, Zahl2, ErgebnisAddition;
            Console.Write("Gebe bitte die 1. Zahl ein: "); Zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gebe bitte die 2. Zahl ein: "); Zahl2 = Convert.ToDouble(Console.ReadLine());

            //Adidtion
            Console.WriteLine("Addition (+): Das Ergebnis lautet: " +(ErgebnisAddition=Zahl1+Zahl2) );
            Console.WriteLine("\n\n(Enter drücken um Programm zu beenden)");
            WarteAufBenutzerEingabe();
        }

        static void WarteAufBenutzerEingabe()
        {
            Console.ReadLine();
        }
    }
}
