using System;

class MainClass {
  public static void Main (string[] args) {

     Console.WriteLine("Digite a base e a altura do triângulo");
     double b = double.Parse(Console.ReadLine());
     double a = double.Parse(Console.ReadLine());
     double area = (b*a);
     double per = ((a*2)+(b*2));
     double m = ((b*b) + (c*c));
     Console.WriteLine($"AREA={area:0.00} PERIMETRO={per:0.00} DIAGONAL={diag:0.00}");
  }
}