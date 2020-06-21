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
            //Benutzereingabe 2er Zahlen als String -> wandelt Text in Double
            double Zahl1, Zahl2, ErgebnisAddition, ErgebnisSubtraktion;
            Zahl1 = Convert.ToDouble(HoleBenutzereingabe("Gebe bitte den ersten Summanden ein: "));
            Zahl2 = Convert.ToDouble(HoleBenutzereingabe("Gebe bitte den zweiten Summanden ein: "));

            //Addition zweier Werte
            Console.WriteLine("Addition (+): Das Ergebnis lautet: " + (ErgebnisAddition = Addiere(Zahl1,Zahl2)));
            HoleBenutzereingabe("\n\n(Enter drücken um Programm zu beenden)");

            //Subtraktion zweier Werte
            Console.WriteLine("Subtraktion (-): Das Ergebnis lautet: " + (ErgebnisSubtraktion = Subtrahiere(Zahl1, Zahl2)));
            HoleBenutzereingabe("\n\n(Enter drücken um Programm zu beenden)");
        }
        static string HoleBenutzereingabe(string EingabeText)           /////HoleBenutzereingabe
        {
            Console.Write(EingabeText);
            string Eingabe = Console.ReadLine();
            return (Eingabe);
        }
        static double Addiere(double Zahl1intern, double Zahl2intern)
        {
            double ErgebnisAdditionIntern = Zahl1intern + Zahl2intern;
            return (ErgebnisAdditionIntern);
        }

        static double Subtrahiere (double Zahl1intern, double Zahl2intern)
        {
            double ErgebnisSubtraktionIntern = Zahl1intern - Zahl2intern;
            return (ErgebnisSubtraktionIntern);
        }
        
    }
}
