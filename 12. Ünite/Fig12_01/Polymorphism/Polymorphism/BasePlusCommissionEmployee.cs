using System;

public class TabanMaasliKomisyonluCalisan : KomisyonluCalisan
{
   private decimal tabanMaas;

   public TabanMaasliKomisyonluCalisan(string ad, string soyad,
      string sosyalGuvenlikNo, decimal brutSatis,
      decimal komisyonOrani, decimal tabanMaas)
      : base(ad, soyad, sosyalGuvenlikNo,
           brutSatis, komisyonOrani)
   {
      TabanMaas = tabanMaas;
   }

   public decimal TabanMaas
   {
      get
      {
         return tabanMaas;
      }
      set
      {
         if (value < 0)
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(TabanMaas)} değeri >= 0 olmalıdır");
         }

         tabanMaas = value;
      }
   }

   public override decimal Kazanc() => TabanMaas + base.Kazanc();

   public override string ToString() =>
      $"taban maaşlı {base.ToString()}\ntaban maaşı: {TabanMaas:C}";
}