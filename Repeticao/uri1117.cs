using System;

class MainClass {
  public static void Main (string[] args) {
double nota1 = 0;
double nota2 = 0;
 
Console.WriteLine("Informe as notas");
  double n1  = double.Parse(Console.ReadLine());  
  double n2  = double.Parse(Console.ReadLine()); 

 while ((n1<0) || (n1>10))
    Console.WriteLine("nota invalida");
    if ((n1 >= 0) || (n1 <=10)) nota1 = n1;

 while ((n2<0) || (n2>10)) Console.WriteLine("nota invalida");
     if ((n2>= 0) || (n2 <= 10))
   nota2 = n2;

 double  media = ((nota1 + nota2)/2); 

Console.WriteLine($"Media = {media:0.00}");

  }
  
}
