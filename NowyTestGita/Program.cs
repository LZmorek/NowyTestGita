using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowyTestGita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ktore haslo chcesz zgadnac?: ");
            Console.WriteLine("1.Haslo Noraza");
            Console.WriteLine("2.Haslo Gomeza");
            Console.WriteLine("trzecia funkcja jaka dodamy");
            Console.WriteLine("czwarta funkcja jaka dodamy");
            int wybor = Convert.ToInt32(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    Program wpisz = new Program();
                    wpisz.Zgaduj();
                    break;
                case 2:
                    Program wpisz2 = new Program();
                    wpisz2.ZgadujHaslo();
                    break;
                default:
                    Console.WriteLine("zly wybor, wybierz 1 lub 2 ");
                    break;
            }
            Console.ReadKey();
        }

        public void ZgadujHaslo()
        {
            while (true)
            {
                Console.WriteLine("podaj slowo haslo:");
                string pytanie = Console.ReadLine();
                if (pytanie.Contains("tajemnica"))
                {
                    Console.WriteLine("Dobra robota");
                    break;
                }
                else
                {
                    Console.WriteLine("wpisz ponownie haslo");
                }

            }
        }
        public void Zgaduj()
        {
            while (true)
            {

                String haslowpisane;
                String haslostale = "Zupa Pomidorowa";
                Console.WriteLine("Prosze podac haslo: ");
                haslowpisane = Console.ReadLine();
                if (haslowpisane.Equals(haslostale))
                {
                    Console.WriteLine("jestes super odgadles haslo");
                    break;
                }
                else
                {
                    Console.WriteLine("jestes BARAaaaaN spróbuj ponownie:");

                }
            }
        }
  
}
