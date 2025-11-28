class Calisan
{
   public string Ad { get; }
   public string Soyad { get; }
   private decimal aylikMaas;

   public Calisan(string ad, string soyad, decimal maas)
   {
      Ad = ad;
      Soyad = soyad;
      AylikMaas = maas;
   }

   public decimal AylikMaas
   {
      get
      {
         return aylikMaas;
      }
      set
      {
         if (value >= 0M)
         {
            aylikMaas = value;
         }
      }
   }

   public override string ToString() =>
      $"{Ad,-10} {Soyad,-10} {AylikMaas,10:C}";
}