using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit eri arvama;
            //kui kasutaja suutis seda numbrit  ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu.
            //*programm genereerib juhuslikku numbrit vaid ühte korda.

            Random rnd = new Random();
            int cpNumber = rnd.Next(1, 11);
            bool a = true;
           
            

            while (a)
            {
                Console.WriteLine($"Sisesta number 1-10");
                int myRandomNumber = Convert.ToInt32(Console.ReadLine());

                if (myRandomNumber == cpNumber)
                {
                    Console.WriteLine("Oled võitja!");
                    a = false;
                }
            }



            Console.WriteLine("Kena päeva!");
            
        }
    }
    }

