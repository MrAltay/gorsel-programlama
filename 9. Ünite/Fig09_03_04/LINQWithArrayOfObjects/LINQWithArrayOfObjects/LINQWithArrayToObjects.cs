using System;
using System.Linq;

class NesneDizileriyleLINQ
{
   static void Main()
   {
      var calisanlar = new[] {
         new Calisan("Jason", "Red", 5000M),
         new Calisan("Ashley", "Green", 7600M),
         new Calisan("Matthew", "Indigo", 3587.5M),
         new Calisan("James", "Indigo", 4700.77M),
         new Calisan("Luke", "Indigo", 6200M),
         new Calisan("Jason", "Blue", 3200M),
         new Calisan("Wendy", "Brown", 4236.4M)};

      Console.WriteLine("Orijinal dizi:");
      foreach (var eleman in calisanlar)
      {
         Console.WriteLine(eleman);
      }

      var maasAraligi =
         from e in calisanlar
         where (e.AylikMaas >= 4000M) && (e.AylikMaas <= 6000M)
         select e;

      Console.WriteLine($"\nAylık {4000:C}-{6000:C} aralığında kazanan çalışanlar:");
      foreach (var eleman in maasAraligi)
      {
         Console.WriteLine(eleman);
      }

      var ismeGoreSirali =
         from e in calisanlar
         orderby e.Soyad, e.Ad
         select e;

      Console.WriteLine("\nİsme göre sıralandığında ilk çalışan:");

      if (ismeGoreSirali.Any())
      {
         Console.WriteLine(ismeGoreSirali.First());
      }
      else
      {
         Console.WriteLine("bulunamadı");
      }

      var soyadlar =
         from e in calisanlar
         select e.Soyad;

      Console.WriteLine("\nBenzersiz çalışan soyadları:");
      foreach (var eleman in soyadlar.Distinct())
      {
         Console.WriteLine(eleman);
      }

      var isimler =
         from e in calisanlar
         select new { e.Ad, e.Soyad };

      Console.WriteLine("\nSadece isimler:");
      foreach (var eleman in isimler)
      {
         Console.WriteLine(eleman);
      }

      Console.WriteLine();
   }
}