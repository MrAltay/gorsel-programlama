using System;

public class Zaman2
{
   private int saat;
   private int dakika;
   private int saniye;

   public Zaman2(int saat = 0, int dakika = 0, int saniye = 0)
   {
      ZamanAyarla(saat, dakika, saniye);
   }

   public Zaman2(Zaman2 zaman)
      : this(zaman.Saat, zaman.Dakika, zaman.Saniye) { }

   public void ZamanAyarla(int saat, int dakika, int saniye)
   {
      Saat = saat;
      Dakika = dakika;
      Saniye = saniye;
   }

   public int Saat
   {
      get
      {
         return saat;
      }
      set
      {
         if (value < 0 || value > 23)
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(Saat)} 0-23 aralığında olmalıdır");
         }

         saat = value;
      }
   }

   public int Dakika
   {
      get
      {
         return dakika;
      }
      set
      {
         if (value < 0 || value > 59)
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(Dakika)} 0-59 aralığında olmalıdır");
         }

         dakika = value;
      }
   }

   public int Saniye
   {
      get
      {
         return saniye;
      }
      set
      {
         if (value < 0 || value > 59)
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(Saniye)} 0-59 aralığında olmalıdır");
         }

         saniye = value;
      }
   }

   public string EvrenselSaatFormatinaDonustur() =>
      $"{Saat:D2}:{Dakika:D2}:{Saniye:D2}";

   public override string ToString() =>
      $"{((Saat == 0 || Saat == 12) ? 12 : Saat % 12)}:" +
      $"{Dakika:D2}:{Saniye:D2} {(Saat < 12 ? "ÖÖ" : "ÖS")}";
}