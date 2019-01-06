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
            Console.WriteLine("Ktore haslo chcesz zgadnac?: ");
            Console.WriteLine("1.Haslo metoda Contains");
            Console.WriteLine("2.Haslo metoda Equals");
            Console.WriteLine("3.Haslo metoda Array");

            int choose = Convert.ToInt32(Console.ReadLine());

            Passwords write = new Passwords();
           
            switch (choose)
            {
                case 1:
                    write.PassGuess();
                    break;
                case 2:
                    write.PassGuess2();
                    break;
                case 3:
                    write.PassGuess3();
                    break;
                default:
                    Console.WriteLine("Bledny wybor, wybierz 1,2 lub 3 ");
                    break;
            }
            Console.ReadKey();
        }        
    }

    class Passwords
    {
        String passWritten;
        String passConst = "Zupa Pomidorowa";
        String[] passArray = new String[3]
        {"kupa" , "gowno" , "sraka"};


        public void PassGuess()
        {
            while (true)
            {             
                Console.WriteLine("podaj slowo haslo:");
                string passWritten = Console.ReadLine();
                if (passWritten.Contains("tajemnica"))
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
        public void PassGuess2()
        {
            while (true)
            {
                Console.WriteLine("Prosze podac haslo: ");
                passWritten = Console.ReadLine();

                if (passWritten.Equals(passConst))
                {
                    Console.WriteLine("jestes super odgadles haslo");
                    break;
                }
                else
                {
                    Console.WriteLine("jestes Baran spróbuj ponownie:");
                    
                }
            }
        }
        public void PassGuess3()
        {
            while (true)
            {
                Console.WriteLine("Podaj jedno z dozwolonych hasel: ");

                passWritten = Console.ReadLine();

                if (passArray.Contains(passWritten))
                {
                    Console.WriteLine("Swietnie! Kupa radosci!");
                    break;
                }

                else
                {
                    Console.WriteLine("Wez sie do kupy chopie!");
                   
                }
                    
            }
        }
    }  
}
