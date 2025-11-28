using System;

class Toplama
{
   static void Main()
   {
      int sayi1;
      int sayi2;
      int toplam;

      Console.Write("Birinci tamsayıyı girin: ");
      sayi1 = int.Parse(Console.ReadLine());

      Console.Write("İkinci tamsayıyı girin: ");
      sayi2 = int.Parse(Console.ReadLine());

      toplam = sayi1 + sayi2;

      Console.WriteLine($"Toplam: {toplam}");
   }
}