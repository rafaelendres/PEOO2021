using System;

class MainClass {
  public static void Main (string[] args) {

 
Console.WriteLine("Informe as notas");
double n1  = double.Parse(Console.ReadLine());  
double n2  = double.Parse(Console.ReadLine());  
 if ((n1 >= 0) && (n1 <=10))
double media = ((n1 + n2) / 2); 
Console.WriteLine($"Media = {media}");

  }
  
}
