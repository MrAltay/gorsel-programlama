using System;

class NotDefteri
{
   private int[,] notlar;

   public string DersAdi { get; }

   public NotDefteri(string ad, int[,] notlarDizisi)
   {
      DersAdi = ad;
      notlar = notlarDizisi;
   }

   public void MesajGoster()
   {
      Console.WriteLine(
         $"\n{DersAdi} not defterine hoş geldiniz!\n");
   }

   public void NotlariIsle()
   {
      NotlariYazdir();

      Console.WriteLine(
         $"\nNot defterindeki en düşük not: {EnDusukBul()}" +
         $"\nNot defterindeki en yüksek not: {EnYuksekBul()}\n");

      GrafikCiz();
   }

   public int EnDusukBul()
   {
      var enDusukNot = notlar[0, 0];

      foreach (var notDegeri in notlar)
      {
         if (notDegeri < enDusukNot)
         {
            enDusukNot = notDegeri;
         }
      }

      return enDusukNot;
   }

   public int EnYuksekBul()
   {
      var enYuksekNot = notlar[0, 0];

      foreach (var notDegeri in notlar)
      {
         if (notDegeri > enYuksekNot)
         {
            enYuksekNot = notDegeri;
         }
      }

      return enYuksekNot;
   }

   public double OrtalamaHesapla(int ogrenci)
   {
      var notSayisi = notlar.GetLength(1);
      var toplam = 0.0;

      for (var sinav = 0; sinav < notSayisi; ++sinav)
      {
         toplam += notlar[ogrenci, sinav];
      }

      return toplam / notSayisi;
   }

   public void GrafikCiz()
   {
      Console.WriteLine("Genel not dağılımı:");

      var siklik = new int[11];

      foreach (var notDegeri in notlar)
      {
         ++siklik[notDegeri / 10];
      }

      for (var sayac = 0; sayac < siklik.Length; ++sayac)
      {
         if (sayac == 10)
         {
            Console.Write("  100: ");
         }
         else
         {
            Console.Write($"{sayac * 10:D2}-{sayac * 10 + 9:D2}: ");
         }

         for (var yildiz = 0; yildiz < siklik[sayac]; ++yildiz)
         {
            Console.Write("*");
         }

         Console.WriteLine();
      }
   }

   public void NotlariYazdir()
   {
      Console.WriteLine("Notlar:\n");
      Console.Write("            ");

      for (var sinav = 0; sinav < notlar.GetLength(1); ++sinav)
      {
         Console.Write($"Sınav {sinav + 1}  ");
      }

      Console.WriteLine("Ortalama");

      for (var ogrenci = 0; ogrenci < notlar.GetLength(0); ++ogrenci)
      {
         Console.Write($"Öğrenci {ogrenci + 1,2}");

         for (var notDegeri = 0; notDegeri < notlar.GetLength(1); ++notDegeri)
         {
            Console.Write($"{notlar[ogrenci, notDegeri],8}");
         }

         Console.WriteLine($"{OrtalamaHesapla(ogrenci),9:F}");
      }
   }
}