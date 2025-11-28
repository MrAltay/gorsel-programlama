using System;

class KarmasikSayiTesti
{
   static void Main()
   {
      Console.Write("x karmaşık sayısının gerçel kısmını girin: ");
      double gercelKisim = double.Parse(Console.ReadLine());
      Console.Write("x karmaşık sayısının sanal kısmını girin: ");
      double sanalKisim = double.Parse(Console.ReadLine());
      var x = new KarmasikSayi(gercelKisim, sanalKisim);

      Console.Write("\ny karmaşık sayısının gerçel kısmını girin: ");
      gercelKisim = double.Parse(Console.ReadLine());
      Console.Write("y karmaşık sayısının sanal kısmını girin: ");
      sanalKisim = double.Parse(Console.ReadLine());
      var y = new KarmasikSayi(gercelKisim, sanalKisim);

      Console.WriteLine();
      Console.WriteLine($"{x} + {y} = {x + y}");
      Console.WriteLine($"{x} - {y} = {x - y}");
      Console.WriteLine($"{x} * {y} = {x * y}");
   }
}