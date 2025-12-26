using System;

class MetinBirlestirme
{
   static void Main()
   {
      var metin1 = "Mutlu ";
      var metin2 = "Doğum Günü";

      Console.WriteLine($"metin1 = \"{metin1}\"");
      Console.WriteLine($"metin2 = \"{metin2}\"");
      Console.WriteLine("\nstring.Concat(metin1, metin2) sonucu = " +
         string.Concat(metin1, metin2));
      Console.WriteLine($"Birleştirmeden sonra metin1 = {metin1}");
   }
}