using System;

  class MainClass {
    
    public static void Main (string[] args) {
      double x = 45.4;
      int y;
      int z;
      Intervalo(x, out y, out z);
      Console.WriteLine(y);
      Console.WriteLine(z);
    }
      
     public static void Intervalo(double x, out int inicio, out int fim) {
        inicio = (int) x;
        fim = inicio + 1;
         }
  }   
  