using System;

class Karsilastirma
{
   static void Main()
   {
      Console.Write("Birinci tamsayıyı girin: ");
      int sayi1 = int.Parse(Console.ReadLine());

      Console.Write("İkinci tamsayıyı girin: ");
      int sayi2 = int.Parse(Console.ReadLine());

      if (sayi1 == sayi2)
      {
         Console.WriteLine($"{sayi1} == {sayi2}");
      }

      if (sayi1 != sayi2)
      {
         Console.WriteLine($"{sayi1} != {sayi2}");
      }

      if (sayi1 < sayi2)
      {
         Console.WriteLine($"{sayi1} < {sayi2}");
      }

      if (sayi1 > sayi2)
      {
         Console.WriteLine($"{sayi1} > {sayi2}");
      }

      if (sayi1 <= sayi2)
      {
         Console.WriteLine($"{sayi1} <= {sayi2}");
      }

      if (sayi1 >= sayi2)
      {
         Console.WriteLine($"{sayi1} >= {sayi2}");
      }
   }
}