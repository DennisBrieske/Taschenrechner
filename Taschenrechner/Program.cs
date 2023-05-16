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

            // Wandel Text in Ganzzahl
            int ersteGanzZahl = Convert.ToInt32(zahl1);
            int zweiteGanzZahl = Convert.ToInt32(zahl2);

            // Berechnung ausführen
            int summe = ersteGanzZahl + zweiteGanzZahl;

            // Ausgabe der Summe
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.ReadLine();

        }
    }
}
