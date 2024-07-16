using System;
namespace Sayi_Bulma
{

	class SayiBul
	{
        static void Main(string[] args)
        {
            Console.Write("Lütfen Bir Sayi Giriniz:");
            int Sayi= Convert.ToInt32( Console.ReadLine());// Sayı değeri alınıyor
            if (Sayi > 10)//Girilen sayı 10'dan büyük mü diye kontrol ediliyor
            {
                Console.WriteLine($"Girilen {Sayi} Sayısı 10'dan büyüktür.");
              

            }
            else if (Sayi <10)//Girilen 10'dan küçük mü diye kontrol ediliyor
            {
                Console.WriteLine($"Girilen {Sayi} Sayısı 10'dan küçüktür.");
                

            }
            else
            {

                Console.WriteLine($"Girilen {Sayi} Sayısı 10'a eşittir.");//Girilen sayı 10 mu diye kontrol ediliyor
            }
           
            if (Sayi % 2 == 0)// Girilen sayının 2 ile bölümden kalan 0 mı?
            {

                Console.WriteLine($"Girilen Sayi Çifttir.");

            }
            else
            {
                Console.WriteLine($"Girilen Sayı Tektir.");
            }

        }

    }

}