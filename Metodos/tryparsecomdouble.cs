using System;

class MainClass {
  public static void Main (string[] args) {
     double x;
     Console.WriteLine("Digite um valor flutuante");
     while(double.TryParse(Console.ReadLine(), out x) == false) {
       Console.WriteLine("Valor é inválido");
       Console.WriteLine("Digite o valor novamente");
     }
     Console.WriteLine(x);
  }
}