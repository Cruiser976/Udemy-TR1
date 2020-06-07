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
            //wandelt Text in Double
            double Zahl1, Zahl2, ErgebnisAddition;
            Console.Write("Gebe bitte die 1. Zahl ein: "); Zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gebe bitte die 2. Zahl ein: "); Zahl2 = Convert.ToDouble(Console.ReadLine());

            //Addition zweier Werte
            Console.WriteLine("Addition (+): Das Ergebnis lautet: " + (ErgebnisAddition = Addiere(Zahl1,Zahl2)));
            WarteAufBenutzerEingabe();
        }

        static double Addiere(double Zahl1intern, double Zahl2intern)
        {
            double ErgebnisAdditionIntern = Zahl1intern + Zahl2intern;
            return (ErgebnisAdditionIntern);
        }

        static void WarteAufBenutzerEingabe()
        {
            Console.WriteLine("\n\n(Enter drücken um Programm zu beenden)");
            Console.ReadLine();
        }
    }
}
