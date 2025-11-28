using System;

class SinavAnalizi
{
   static void Main()
   {
      int gecenler = 0;
      int kalanlar = 0;
      int ogrenciSayaci = 1;

      while (ogrenciSayaci <= 10)
      {
         Console.Write("Sonucu girin (1 = geçti, 2 = kaldı): ");
         int sonuc = int.Parse(Console.ReadLine());

         if (sonuc == 1)
         {
            gecenler = gecenler + 1;
         }
         else
         {
            kalanlar = kalanlar + 1;
         }

         ogrenciSayaci = ogrenciSayaci + 1;
      }

      Console.WriteLine($"Geçen: {gecenler}\nKalan: {kalanlar}");

      if (gecenler > 8)
      {
         Console.WriteLine("Eğitmene bonus!");
      }
   }
}