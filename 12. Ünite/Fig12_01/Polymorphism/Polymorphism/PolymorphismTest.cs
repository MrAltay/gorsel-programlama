using System;

class PolimorfizmTesti
{
   static void Main()
   {
      var komisyonluCalisan = new KomisyonluCalisan(
         "Sue", "Jones", "222-22-2222", 10000.00M, .06M);

      var tabanMaasliKomisyonluCalisan = new TabanMaasliKomisyonluCalisan(
         "Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

      Console.WriteLine(
         "Temel sınıf referansı ile temel sınıf nesnesinin " +
         "ToString ve Kazanc metotlarını çağırma\n");
      Console.WriteLine(komisyonluCalisan.ToString());
      Console.WriteLine($"kazanç: {komisyonluCalisan.Kazanc()}\n");

      Console.WriteLine("Türetilmiş sınıf referansı ile türetilmiş " +
         "sınıf nesnesinin ToString ve Kazanc metotlarını " +
         "çağırma\n");
      Console.WriteLine(tabanMaasliKomisyonluCalisan.ToString());
      Console.WriteLine(
         $"kazanç: {tabanMaasliKomisyonluCalisan.Kazanc()}\n");

      KomisyonluCalisan komisyonluCalisan2 = tabanMaasliKomisyonluCalisan;
      Console.WriteLine(
         "Temel sınıf referansı ile türetilmiş sınıf nesnesinin " +
         "ToString ve Kazanc metotlarını çağırma\n");
      Console.WriteLine(komisyonluCalisan2.ToString());
      Console.WriteLine(
         $"kazanç: {tabanMaasliKomisyonluCalisan.Kazanc()}\n");
   }
}