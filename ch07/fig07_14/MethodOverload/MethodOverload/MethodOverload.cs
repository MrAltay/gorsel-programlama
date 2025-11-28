using System;

class MetotAsiriYukleme
{
   static void Main()
   {
      Console.WriteLine($"7 tamsayısının karesi: {KareAl(7)}");
      Console.WriteLine($"7.5 ondalık sayısının karesi: {KareAl(7.5)}");
   }

   static int KareAl(int tamSayi)
   {
      Console.WriteLine($"int argümanıyla kare alma çağrıldı: {tamSayi}");
      return tamSayi * tamSayi;
   }

   static double KareAl(double ondalikSayi)
   {
      Console.WriteLine(
         $"double argümanıyla kare alma çağrıldı: {ondalikSayi}");
      return ondalikSayi * ondalikSayi;
   }
}