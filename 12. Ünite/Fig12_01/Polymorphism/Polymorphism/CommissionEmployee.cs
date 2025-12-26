using System;

public class KomisyonluCalisan
{
   public string Ad { get; }
   public string Soyad { get; }
   public string SosyalGuvenlikNo { get; }
   private decimal brutSatis; 
   private decimal komisyonOrani; 

   public KomisyonluCalisan(string ad, string soyad,
      string sosyalGuvenlikNo, decimal brutSatis,
      decimal komisyonOrani)
   {
      Ad = ad;
      Soyad = soyad;
      SosyalGuvenlikNo = sosyalGuvenlikNo;
      BrutSatis = brutSatis; 
      KomisyonOrani = komisyonOrani; 
   }

   public decimal BrutSatis
   {
      get
      {
         return brutSatis;
      }
      set
      {
         if (value < 0) 
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(BrutSatis)} değeri >= 0 olmalıdır");
         }

         brutSatis = value;
      }
   }

   public decimal KomisyonOrani
   {
      get
      {
         return komisyonOrani;
      }
      set
      {
         if (value <= 0 || value >= 1) 
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(KomisyonOrani)} değeri > 0 ve < 1 olmalıdır");
         }

         komisyonOrani = value;
      }
   }

   public virtual decimal Kazanc() => KomisyonOrani * BrutSatis;

   public override string ToString() =>
      $"komisyonlu çalışan: {Ad} {Soyad}\n" +
      $"sosyal güvenlik numarası: {SosyalGuvenlikNo}\n" +
      $"brüt satış: {BrutSatis:C}\n" +
      $"komisyon oranı: {KomisyonOrani:F2}";
}