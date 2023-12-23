using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boy_kilo_odevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ödev Soru: Boy, kilo ve cinsiyet bilgileri girildiğinde ideal kiloda olup olmadığını ekrana yazan programın algortimasını yazınız veya çiziniz veya kodlayınız.
             • Kadınlarda ideal kilo: 45.5 + 2.3 X (İnç cinsinden boy - 60)
             • Erkeklerde ideal kilo: 50 + 2.3 X (İnç cinsinden boy - 60)
             1 inç = 2,54 cm */



            Console.WriteLine("lütfen cinsiyetinizi giriniz erkek ise 'E' Kadın ise 'K':");
            string cinsiyet = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Lütfen kilonuzu giriniz:");
            double kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen boyunuzu giriniz: ");
            double boy = Convert.ToInt32(Console.ReadLine());



            if (cinsiyet.ToLower() == "e")
            {
                double ideal1  = Math.Floor(50 + 2.3 * ((boy / 2.54) - 60));

                if (ideal1 < kilo)
                {
                    Console.WriteLine("ideal kiloya ulaşabilmek için " + (kilo - ideal1) + " kilo vermeniz gerekmektedir: ");
                }

                if (ideal1 > kilo) 
                {
                    Console.WriteLine("ideal kiloya ulaşabilmek için " + (ideal1-kilo) + " kilo almanız gerekmektedir: ");

                }


            }


            if (cinsiyet.ToLower() == "k")
            {
                double ideal2 = Math.Floor(45.5 + 2.3 * ((boy / 2.54) - 60));

                if (ideal2 < kilo)
                {
                    Console.WriteLine("ideal kiloya ulaşabilmek için " + (kilo - ideal2) + " kilo vermeniz gerekmektedir: ");
                }

                if (ideal2 > kilo)
                {
                    Console.WriteLine("ideal kiloya ulaşabilmek için " + (ideal2 - kilo) + " kilo almanız gerekmektedir: ");

                }

            }




        }
    }
}
