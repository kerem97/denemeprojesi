using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, sayac = 0, sayi;
            double ort;
            Console.Write("Bir sayı giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi != 0)
            {
                sayac++;
                toplam += sayi;
                Console.Write("Bir sayı giriniz :");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            if (sayac != 0)
            {
                ort = (double)toplam / sayac;
                Console.WriteLine("Sayıların ortalaması={0}", ort);
            }
            else
            {
                Console.WriteLine("Sayı girilmedi");
            }
            Console.ReadKey();
            
        }
    }
}
