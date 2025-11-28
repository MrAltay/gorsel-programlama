using System;

class DiziReferansTesti
{
   static void Main()
   {
      int[] birinciDizi = { 1, 2, 3 };
      int[] birinciDiziKopya = birinciDizi;

      Console.WriteLine("birinciDizi referansını değer olarak geçirme testi");
      Console.Write(
         "IlkDiziyiKatla metodundan önce birinciDizi içeriği:\n\t");

      foreach (var eleman in birinciDizi)
      {
         Console.Write($"{eleman} ");
      }

      IlkDiziyiKatla(birinciDizi);

      Console.Write(
         "\nIlkDiziyiKatla metodundan sonra birinciDizi içeriği:\n\t");

      foreach (var eleman in birinciDizi)
      {
         Console.Write($"{eleman} ");
      }

      if (birinciDizi == birinciDiziKopya)
      {
         Console.WriteLine("\n\nReferanslar aynı diziye işaret ediyor");
      }
      else
      {
         Console.WriteLine(
            "\n\nReferanslar farklı dizilere işaret ediyor");
      }

      int[] ikinciDizi = { 1, 2, 3 };
      int[] ikinciDiziKopya = ikinciDizi;

      Console.WriteLine(
         "\nikinciDizi referansını referans (ref) olarak geçirme testi");
      Console.Write(
         "IkinciDiziyiKatla metodundan önce ikinciDizi içeriği:\n\t");

      foreach (var eleman in ikinciDizi)
      {
         Console.Write($"{eleman} ");
      }

      IkinciDiziyiKatla(ref ikinciDizi);

      Console.Write(
         "\nIkinciDiziyiKatla metodundan sonra ikinciDizi içeriği:\n\t");

      foreach (var eleman in ikinciDizi)
      {
         Console.Write($"{eleman} ");
      }

      if (ikinciDizi == ikinciDiziKopya)
      {
         Console.WriteLine("\n\nReferanslar aynı diziye işaret ediyor");
      }
      else
      {
         Console.WriteLine(
            "\n\nReferanslar farklı dizilere işaret ediyor");
      }
   }

   static void IlkDiziyiKatla(int[] dizi)
   {
      for (var i = 0; i < dizi.Length; ++i)
      {
         dizi[i] *= 2;
      }

      dizi = new int[] { 11, 12, 13 };
   }

   static void IkinciDiziyiKatla(ref int[] dizi)
   {
      for (var i = 0; i < dizi.Length; ++i)
      {
         dizi[i] *= 2;
      }

      dizi = new int[] { 11, 12, 13 };
   }
}