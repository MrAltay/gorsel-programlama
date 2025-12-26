using System;

public class EklemeSiralamasiTesti
{
   static void Main()
   {
      var uretici = new Random();
      var veriler = new int[10]; 

      for (var i = 0; i < veriler.Length; ++i)
      {
         veriler[i] = uretici.Next(10, 100);
      }

      Console.WriteLine("Sıralanmamış dizi:");
      Console.WriteLine(string.Join(" ", veriler) + "\n"); 

      EklemeSiralamasi(veriler); 

      Console.WriteLine("Sıralanmış dizi:");
      Console.WriteLine(string.Join(" ", veriler) + "\n"); 
   }

   public static void EklemeSiralamasi(int[] degerler)
   {
      for (var siradaki = 1; siradaki < degerler.Length; ++siradaki)
      {
         var eklenecek = degerler[siradaki];

         var yerDegistir = siradaki;

         while (yerDegistir > 0 && degerler[yerDegistir - 1] > eklenecek)
         {
            degerler[yerDegistir] = degerler[yerDegistir - 1];
            yerDegistir--;
         }

         degerler[yerDegistir] = eklenecek; 
         AdimiYazdir(degerler, siradaki, yerDegistir); 
      }
   }

   public static void AdimiYazdir(int[] degerler, int adim, int indeks)
   {
      Console.Write($"{adim}. adımdan sonra: ");

      for (var i = 0; i < indeks; ++i)
      {
         Console.Write($"{degerler[i]}  ");
      }

      Console.Write($"{degerler[indeks]}* "); 

      for (var i = indeks + 1; i < degerler.Length; ++i)
      {
         Console.Write($"{degerler[i]}  ");
      }

      Console.Write("\n              "); 

      for (var i = 0; i <= adim; ++i)
      {
         Console.Write("--  ");
      }

      Console.WriteLine("\n"); 
   }
}