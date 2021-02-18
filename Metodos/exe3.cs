using System;

  class MainClass {
    
    public static void Main (string[] args) {
      int x;
      Intervalo(out x);
      Console.WriteLine($"Intervalo: {x.Start} a {x.End}");
      
      
      public static void Intervalo(double x, out int inicio, out int fim) {
      x = double.Parse(Console.ReadLine());
      return x;
         }
  }
  }