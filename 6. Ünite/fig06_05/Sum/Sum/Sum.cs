using System;

class Toplam
{
   static void Main()
   {
      int toplam = 0;

      for (int sayi = 2; sayi <= 20; sayi += 2)
      {
         toplam += sayi;
      }

      Console.WriteLine($"Toplam: {toplam}");
   }
}