using System;

class ReferansVeCikisParametreleri
{
   static void Main()
   {
      int y = 5;
      int z;

      Console.WriteLine($"y'nin orijinal değeri: {y}");
      Console.WriteLine("z'nin orijinal değeri: başlatılmamış\n");

      KareAlRef(ref y);
      KareAlOut(out z);

      Console.WriteLine($"KareAlRef sonrası y'nin değeri: {y}");
      Console.WriteLine($"KareAlOut sonrası z'nin değeri: {z}\n");

      KareAl(y);
      KareAl(z);

      Console.WriteLine($"KareAl sonrası y'nin değeri: {y}");
      Console.WriteLine($"KareAl sonrası z'nin değeri: {z}");
   }

   static void KareAlRef(ref int x)
   {
      x = x * x;
   }

   static void KareAlOut(out int x)
   {
      x = 6;
      x = x * x;
   }

   static void KareAl(int x)
   {
      x = x * x;
   }
}