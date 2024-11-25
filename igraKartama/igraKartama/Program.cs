using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraKartama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karte = 0;
            int brojacKarti = 0;
            Console.WriteLine("Unesi kartu izmedu 1 i 13");
            while (brojacKarti < 31)
            {


                karte = Convert.ToInt32(Console.ReadLine());


                if (karte <= 13 && karte >= 1)
                {
                    brojacKarti += karte;
                }
                else
                {
                    Console.WriteLine("Unesi ispravnu kartu od 1 do 13");
                }
            }
                if (brojacKarti > 31)
                {
                    Console.WriteLine("Gubitak");

                }
                else if  (brojacKarti == 31)
                {
                    Console.WriteLine("pobjeda");
                }
                Console.ReadKey();
            



        }
    }
}
