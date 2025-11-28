using System;

class SinifOrtalamasi
{
   static void Main()
   {
      int toplam = 0;
      int notSayaci = 0;

      Console.Write("Notu girin veya çıkmak için -1 yazın: ");
      int notDegeri = int.Parse(Console.ReadLine());

      while (notDegeri != -1)
      {
         toplam = toplam + notDegeri;
         notSayaci = notSayaci + 1;

         Console.Write("Notu girin veya çıkmak için -1 yazın: ");
         notDegeri = int.Parse(Console.ReadLine());
      }

      if (notSayaci != 0)
      {
         double ortalama = (double)toplam / notSayaci;

         Console.WriteLine($"\nGirilen {notSayaci} notun toplamı: {toplam}");
         Console.WriteLine($"Sınıf ortalaması: {ortalama:F}");
      }
      else
      {
         Console.WriteLine("Hiç not girilmedi");
      }
   }
}