using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Story "Addieren": Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen zu lassen
            Console.Write("Bitte gib die erste Zahl ein: ");
            string zahl1 = Console.ReadLine();
            Console.Write("Bitte gib die zweite Zahl ein: ");
            string zahl2 = Console.ReadLine();

            // Wandel Text in Gleitkommazahl
            double ersteGanzZahl = Convert.ToDouble(zahl1);
            double zweiteGanzZahl = Convert.ToDouble(zahl2);

            // Berechnung ausführen
            double summe = Addiere(ersteGanzZahl, zweiteGanzZahl);

            // Ausgabe der Summe
            Console.WriteLine("Die Summe ist: {0}", summe);

            WarteAufBenutzerEingabe();
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;

            return summe;
        }

        static void WarteAufBenutzerEingabe()
        {
            Console.Write("Zum Beenden RETURN drücken!");
            Console.ReadLine();
        }
    }
}
