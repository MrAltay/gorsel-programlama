using System;
using System.Collections.Generic;

class ListeKoleksiyonu
{
   static void Main()
   {
      var ogeler = new List<string>();

      Console.WriteLine("Öğelere ekleme yapmadan önce: " +
         $"Adet = {ogeler.Count}; Kapasite = {ogeler.Capacity}");

      ogeler.Add("kırmızı");
      ogeler.Insert(0, "sarı");

      Console.WriteLine("Öğelere iki eleman ekledikten sonra: " +
         $"Adet = {ogeler.Count}; Kapasite = {ogeler.Capacity}");

      Console.Write(
         "\nSayaç kontrollü döngü ile liste içeriğini göster:");
      for (var i = 0; i < ogeler.Count; i++)
      {
         Console.Write($" {ogeler[i]}");
      }

      Console.Write("\nForeach ifadesi ile liste içeriğini göster:");
      foreach (var oge in ogeler)
      {
         Console.Write($" {oge}");
      }

      ogeler.Add("yeşil");
      ogeler.Add("sarı");

      Console.WriteLine("\n\nÖğelere iki eleman daha ekledikten sonra: " +
         $"Adet = {ogeler.Count}; Kapasite = {ogeler.Capacity}");

      Console.Write("İki yeni elemanlı liste:");
      foreach (var oge in ogeler)
      {
         Console.Write($" {oge}");
      }

      ogeler.Remove("sarı");

      Console.Write("\n\nSarı'nın ilk örneğini kaldır:");
      foreach (var oge in ogeler)
      {
         Console.Write($" {oge}");
      }

      ogeler.RemoveAt(1);

      Console.Write("\nİkinci liste elemanını (yeşil) kaldır:");
      foreach (var oge in ogeler)
      {
         Console.Write($" {oge}");
      }

      Console.WriteLine("\nÖğelerden iki eleman kaldırdıktan sonra: " +
         $"Adet = {ogeler.Count}; Kapasite = {ogeler.Capacity}");

      Console.WriteLine("\n\"kırmızı\" listede " +
         $"{(ogeler.Contains("kırmızı") ? "var" : "yok")}");

      ogeler.Add("turuncu");
      ogeler.Add("mor");
      ogeler.Add("mavi");

      Console.WriteLine("\nÖğelere üç eleman daha ekledikten sonra: " +
         $"Adet = {ogeler.Count}; Kapasite = {ogeler.Capacity}");

      Console.Write("Üç yeni elemanlı liste:");
      foreach (var oge in ogeler)
      {
         Console.Write($" {oge}");
      }
      Console.WriteLine();
   }
}