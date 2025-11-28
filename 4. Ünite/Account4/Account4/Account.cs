class Hesap
{
   public string Ad { get; set; }
   private decimal bakiye;

   public Hesap(string hesapAdi, decimal baslangicBakiyesi)
   {
      Ad = hesapAdi;
      Bakiye = baslangicBakiyesi;
   }

   public decimal Bakiye
   {
      get
      {
         return bakiye;
      }
      private set
      {
         if (value > 0.0m)
         {
            bakiye = value;
         }
      }
   }

   public void ParaYatir(decimal yatirilacakMiktar)
   {
      if (yatirilacakMiktar > 0.0m)
      {
         Bakiye = Bakiye + yatirilacakMiktar;
      }
   }
}