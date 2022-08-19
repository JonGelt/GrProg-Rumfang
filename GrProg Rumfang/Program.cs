using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumfangsudrenging
{
    public class Program
    {
        //Static ints med bredde, længde, højde til at bruge i programmet
        private static int h;
        private static int l;
        private static int b;

        static void Main(string[] args)
        {
            //jeg bruger type ConsoleKeyInfo variabel til at kunne registrere input nede i readkey 
            ConsoleKeyInfo input;
            do
            {
                Console.WriteLine("I dette program kan du udregne rumfanget at et objekt \n \nFor at udregne rumfanget af dit objekt skal du indtaste bredden, længden og højden af dit objekt i centimeter ");
                Console.WriteLine("\nTryk på en knap for at fortsætte");
                Console.ReadKey();
                Console.Clear();
                // kalder på indtast metoden for at få h,l,b op i den lokale "tal" int[]
                int[] tal = IndtastCM();
                Console.WriteLine($"Dette er dine tal: \n\nBredde: {tal[0]} Længde: {tal[1]} Højde: {tal[2]}");
                Console.WriteLine("\nTryk på en knap for at udregne");
                Console.ReadKey();
                Console.Clear();
                // kalder på rumfangs udregner og sender tal ned fra tidligere, i udregneren ganger den de tal jeg sender ned or returnere en int rumfang, i stedet for en array
                int rumfang = RumfangUdregner(tal);
                Console.WriteLine($"Dette er dine tal: \n\nBredde: {tal[0]} Længde: {tal[1]} Højde: {tal[2]}");
                Console.WriteLine($"\nRumfanget af objektet er: {rumfang}");
                Console.WriteLine("\nTryk på en knap for at regne rumfanget ud af et andet objekt, ellers tryk ESC for at slutte programet");
                input = Console.ReadKey();
                Console.Clear();

            } while (input.Key != ConsoleKey.Escape);
            //Mens input ikke er escape looper programmet    
        }
        //Her indtaster man sine dimensioner
        static int[] IndtastCM()
        {
            string bredde;
            string længde;
            string højde;
            // Do while der looper indtil det man har skrevet kan blive convertet til en int, i det her tilfælde convertes der fra string bredde, som er input, om til b int, som skal lægges i arrayet der sendes tilbage                                     
            do
            {
                Console.WriteLine("Indtast Bredden:");
                //En fejlmeddelses metode der kan bruges under alle dimensioner, i metoden er der en string s, for at ændre stringen til noget inviduelt for hver input skriver man "string" = metode
                bredde = FejlMeddelse();

            } while (!int.TryParse(bredde, out b));

            do
            {
                Console.WriteLine("Indtast Lændgen:");
                længde = FejlMeddelse();

            } while (!int.TryParse(længde, out l));

            do
            {
                Console.WriteLine("Indtast Højden:");
                højde = FejlMeddelse();

            } while (!int.TryParse(højde, out h));
            // Den her array tager alle ints der bliver outputtet af de tidligere inputs som gik igennem og så bliver den sendt tilbage
            int[] Tal = new int[3] { b, l, h };

            return Tal;

        }

        private static string FejlMeddelse()
        {
            string s = Console.ReadLine();
            //Hvis stringen indeholder bogstaver sender den fejlmeddelse
            if (!int.TryParse(s, out b))
            {
                Console.Clear();
                Console.WriteLine($"{s} er ikke et tal ");
                Console.ReadKey();
                Console.Clear();
            }

            return s;
        }

        static int RumfangUdregner(int[] Tal)
        {
            // her bliver tal arrayet ganget med hinanden og så lavet om til int rumfang og dermed returneret
            int Rumfang = Tal[0] * Tal[1] * Tal[2];

            return Rumfang;

        }


    }
}
