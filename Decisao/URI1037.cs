using System;

class MainClass {
  public static void Main (string[] args) {
 
Console.WriteLine("Insira um número");
double n = double.Parse(Console.ReadLine());
if (n >= 0 && n <= 25) Console.WriteLine("Intervalo [0,25]");
if (n > 25 && n <= 50) Console.WriteLine("Intervalo (25,50]");
if (n > 50 && n <= 75) Console.WriteLine("Intervalo (50,75]");
if (n > 75 && n <= 100) Console.WriteLine("Intervalo (75,100]");if (n > 100 || n < 0) Console.WriteLine("Fora de intervalo");
 
 }
}

