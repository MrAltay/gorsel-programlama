using System;

public struct KarmasikSayi
{
   public double Gercel { get; }
   public double Sanal { get; }

   public KarmasikSayi(double gercel, double sanal)
   {
      Gercel = gercel;
      Sanal = sanal;
   }

   public override string ToString() =>
      $"({Gercel} {(Sanal < 0 ? "-" : "+")} {Math.Abs(Sanal)}i)";

   public static KarmasikSayi operator+(KarmasikSayi x, KarmasikSayi y)
   {
      return new KarmasikSayi(x.Gercel + y.Gercel,
         x.Sanal + y.Sanal);
   }

   public static KarmasikSayi operator-(KarmasikSayi x, KarmasikSayi y)
   {
      return new KarmasikSayi(x.Gercel - y.Gercel,
         x.Sanal - y.Sanal);
   }

   public static KarmasikSayi operator*(KarmasikSayi x, KarmasikSayi y)
   {
      return new KarmasikSayi(
         x.Gercel * y.Gercel - x.Sanal * y.Sanal,
         x.Gercel * y.Sanal + y.Gercel * x.Sanal);
   }
}