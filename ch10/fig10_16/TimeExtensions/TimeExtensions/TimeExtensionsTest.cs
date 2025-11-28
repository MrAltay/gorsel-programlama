using System;

class ZamanGenisletmeleriTesti
{
   static void Main()
   {
      var zamanim = new Zaman2(); 
      zamanim.ZamanAyarla(11, 34, 15); 

      Console.Write("ZamaniGoster genişletme metodunu kullan: ");
      zamanim.ZamaniGoster();

      Console.Write("SaatEkle genişletme metodu ile 5 saat ekle: ");
      var eklenmisZaman = zamanim.SaatEkle(5); 
      eklenmisZaman.ZamaniGoster(); 

      Console.Write("SaatEkle genişletme metodu ile 15 saat ekle: ");
      zamanim.SaatEkle(15).ZamaniGoster(); 

      Console.Write("Tam nitelikli genişletme metodu adını kullan: ");
      ZamanGenisletmeleri.ZamaniGoster(zamanim);
   }
}

static class ZamanGenisletmeleri
{
   public static void ZamaniGoster(this Zaman2 birZaman)
   {
      Console.WriteLine(birZaman.ToString());
   }

   public static Zaman2 SaatEkle(this Zaman2 birZaman, int saatler)
   {
      var yeniZaman = new Zaman2() {
         Dakika = birZaman.Dakika, Saniye = birZaman.Saniye};

      yeniZaman.Saat = (birZaman.Saat + saatler) % 24;

      return yeniZaman; 
   }
}