using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Ubahnfahrt", teiltext;
            //int zahl, zahl2;
            //char zeichen;
            //zeichen = text[3]; //Würde in diesem Fall das Zeichen s beinhalten [0,1,2,3]
            //zahl = text.IndexOf('f');//bei einem zeichen nur das hochkommata über shift+# . Hier sucht er nach der Stelle des zeichen
            //teiltext = text.Substring(2, 4);//Ab der Position 2 packt er das rein. In dem Fall ahnf (1,2,3,4); nach KOmma zeigt es wie viele char er weiter gehen soll
            //zahl2 = text.Length;

            string adresse, teilips = "";
            bool ergebnis = true;
            int laenge = 0, teilip = 0, gesamt, pruf = 0;
            double pruf2;


            Console.WriteLine("Bitte geben Sie die zu überprüfende IP-Adresse an:");
            adresse = Console.ReadLine(); //gesamte IP adresse
            gesamt = adresse.Length; //Länge der IP-Adresse
            if (!(gesamt >= 7 && gesamt <= 15)) //Ist die IP-Adresse min 7 max 15 lang?
            {
                Console.WriteLine("Die IP-Adresse ist ÜNGÜLTIG!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            pruf2 = adresse.IndexOf('.');
            if (pruf2 > 3)
            {
                Console.WriteLine("Die IP-Adresse ist ÜNGÜLTIG!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            //Console.WriteLine("1. IP " + adresse);
            //Überprüfung des ersten IP Teils
            adresse = Uberprufung(laenge, teilip, pruf, adresse, teilips, ergebnis);
            //Console.WriteLine("2. IP " + adresse);
            //Überprüfung zweite Segment
            adresse = Uberprufung(laenge, teilip, pruf, adresse, teilips, ergebnis);
            //Console.WriteLine("3. IP " + adresse);
            //Überprüfung dritte Segment
            adresse = Uberprufung(laenge, teilip, pruf, adresse, teilips, ergebnis);
            //Console.WriteLine("4. IP " + adresse);
            //Überprüfung vierte Segment
            Letzte(pruf, laenge, teilip, adresse, teilips, ergebnis);
            Console.ReadKey();
        }

        static string Uberprufung(int laenge, int teilip, int pruf, string adresse, string teilips, bool ergebnis)
        {
            laenge = adresse.IndexOf('.');//wo der Punkt auftaucht
            teilips = adresse.Substring(0, laenge);//zu überprüfende Teil IP
            pruf = teilips.Length;
            if (!int.TryParse(teilips, out teilip)) //Überprüfung ob die IP nur aus Zahlen besteht
            {
                ergebnis = false;
            }
            if (!(teilip >= 0 && teilip <= 255)) //Prüfen ob die IP zwischen 1 und 255 ist
            {
                ergebnis = false;
            }
            if (!ergebnis)//bool Ausgabe
            {
                Console.WriteLine("Die IP-Adresse ist ÜNGÜLTIG!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return adresse = adresse.Substring(pruf+1);
        }

        static bool Letzte(int pruf, int laenge, int teilip, string adresse, string teilips, bool ergebnis)
        {
            laenge = adresse.Length;//Länge der IP
            teilips = adresse.Substring(0, laenge);
            pruf = teilips.Length;
            if (!int.TryParse(teilips, out teilip)) //Überprüfung ob die IP nur aus Zahlen besteht
            {
                ergebnis = false;
            }
            if (!(teilip >= 0 && teilip <= 255)) //Prüfen ob die IP zwischen 1 und 255 ist
            {
                ergebnis = false;
            }
            if (ergebnis)//bool Ausgabe
            {
                Console.WriteLine("Die IP-Adresse ist gültig");
            }
            else
            {
                Console.WriteLine("Die IP-Adresse ist ÜNGÜLTIG!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            return ergebnis = true;
        }
    }
}
