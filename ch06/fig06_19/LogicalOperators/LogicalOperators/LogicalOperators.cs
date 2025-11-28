using System;

class MantiksalOperatorler
{
   static void Main()
   {
      Console.WriteLine("Koşullu VE (&&)");
      Console.WriteLine($"false && false: {false && false}");
      Console.WriteLine($"false && true: {false && true}");
      Console.WriteLine($"true && false: {true && false}");
      Console.WriteLine($"true && true: {true && true}\n");

      Console.WriteLine("Koşullu VEYA (||)");
      Console.WriteLine($"false || false: {false || false}");
      Console.WriteLine($"false || true: {false || true}");
      Console.WriteLine($"true || false: {true || false}");
      Console.WriteLine($"true || true: {true || true}\n");

      Console.WriteLine("Mantıksal VE (&)");
      Console.WriteLine($"false & false: {false & false}");
      Console.WriteLine($"false & true: {false & true}");
      Console.WriteLine($"true & false: {true & false}");
      Console.WriteLine($"true & true: {true & true}\n");

      Console.WriteLine("Mantıksal Kapsayıcı VEYA (|)");
      Console.WriteLine($"false | false: {false | false}");
      Console.WriteLine($"false | true: {false | true}");
      Console.WriteLine($"true | false: {true | false}");
      Console.WriteLine($"true | true: {true | true}\n");

      Console.WriteLine("Mantıksal Özel VEYA (^)");
      Console.WriteLine($"false ^ false: {false ^ false}");
      Console.WriteLine($"false ^ true: {false ^ true}");
      Console.WriteLine($"true ^ false: {true ^ false}");
      Console.WriteLine($"true ^ true: {true ^ true}\n");

      Console.WriteLine("Mantıksal Değil (!)");
      Console.WriteLine($"!false: {!false}");
      Console.WriteLine($"!true: {!true}");
   }
}