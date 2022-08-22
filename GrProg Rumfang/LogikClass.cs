using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RumfangsudrengingLogik
{
    public class Logik
    {
        //Static ints med bredde, længde, højde til at bruge i programmet
        public static int h;
        public static int l;
        public static int b;

        //Her indtaster man sine dimensioner
       public static int[] IndtastCM()
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

       public static int RumfangUdregner(int[] Tal)
        {
            // her bliver tal arrayet ganget med hinanden og så lavet om til int rumfang og dermed returneret
            int Rumfang = Tal[0] * Tal[1] * Tal[2];

            return Rumfang;

        }

    }
}
