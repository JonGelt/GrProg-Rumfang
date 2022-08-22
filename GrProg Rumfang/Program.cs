
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Rumfangsudrenging
{
    public class Program
    {
                
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
                int[] tal = RumfangsudrengingLogik.Logik.IndtastCM();
                Console.WriteLine($"Dette er dine tal: \n\nBredde: {tal[0]} Længde: {tal[1]} Højde: {tal[2]}");
                Console.WriteLine("\nTryk på en knap for at udregne");
                Console.ReadKey();
                Console.Clear();
                // kalder på rumfangs udregner og sender tal ned fra tidligere, i udregneren ganger den de tal jeg sender ned or returnere en int rumfang, i stedet for en array
                int rumfang = RumfangsudrengingLogik.Logik.RumfangUdregner(tal);
                Console.WriteLine($"Dette er dine tal: \n\nBredde: {tal[0]} Længde: {tal[1]} Højde: {tal[2]}");
                Console.WriteLine($"\nRumfanget af objektet er: {rumfang}");
                Console.WriteLine("\nTryk på en knap for at regne rumfanget ud af et andet objekt, ellers tryk ESC for at slutte programet");
                input = Console.ReadKey();
                Console.Clear();

            } while (input.Key != ConsoleKey.Escape);
            //Mens input ikke er escape looper programmet    
        }
       

    }
}
