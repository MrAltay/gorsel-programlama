using System;

class IstisnalariKullanma
{
   static void Main()
   {
      Console.WriteLine("HataFirlatmaz cagiriliyor");
      HataFirlatmaz();

      Console.WriteLine("\nHataFirlatVeYakala cagiriliyor");
      HataFirlatVeYakala();

      Console.WriteLine("\nHataFirlatVeYakalama cagiriliyor");

      try
      {
         HataFirlatVeYakalama();
      }
      catch
      {
         Console.WriteLine(
            "Main icinde HataFirlatVeYakalama'dan gelen hata yakalandi");
      }

      Console.WriteLine("\nHataFirlatYakalaVeTekrarFirlat cagiriliyor");

      try
      {
         HataFirlatYakalaVeTekrarFirlat();
      }
      catch
      {
         Console.WriteLine(
            "Main icinde HataFirlatYakalaVeTekrarFirlat'tan gelen hata yakalandi");
      }
   }

   static void HataFirlatmaz()
   {
      try
      {
         Console.WriteLine("HataFirlatmaz icinde");
      }
      catch
      {
         Console.WriteLine("Bu catch asla calismaz");
      }
      finally
      {
         Console.WriteLine("HataFirlatmaz icinde finally calisti");
      }

      Console.WriteLine("HataFirlatmaz sonu");
   }

   static void HataFirlatVeYakala()
   {
      try
      {
         Console.WriteLine("HataFirlatVeYakala icinde");
         throw new Exception("HataFirlatVeYakala icinde hata");
      }
      catch (Exception hataParametresi)
      {
         Console.WriteLine($"Mesaj: {hataParametresi.Message}");
      }
      finally
      {
         Console.WriteLine(
            "HataFirlatVeYakala icinde finally calisti");
      }

      Console.WriteLine("HataFirlatVeYakala sonu");
   }

   static void HataFirlatVeYakalama()
   {
      try
      {
         Console.WriteLine("HataFirlatVeYakalama icinde");
         throw new Exception("HataFirlatVeYakalama icinde hata");
      }
      finally
      {
         Console.WriteLine(
            "HataFirlatVeYakalama icinde finally calisti");
      }

      Console.WriteLine("HataFirlatVeYakalama sonu");
   }

   static void HataFirlatYakalaVeTekrarFirlat()
   {
      try
      {
         Console.WriteLine("HataFirlatYakalaVeTekrarFirlat icinde");
         throw new Exception("HataFirlatYakalaVeTekrarFirlat icinde hata");
      }
      catch (Exception hataParametresi)
      {
         Console.WriteLine("Mesaj: " + hataParametresi.Message);
         throw;
      }
      finally
      {
         Console.WriteLine(
            "HataFirlatYakalaVeTekrarFirlat icinde finally calisti");
      }

      Console.WriteLine("HataFirlatYakalaVeTekrarFirlat sonu");
   }
}