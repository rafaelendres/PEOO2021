using System;

class MainClass {
  public static void Main (string[] args) {

    int n1, n2;
    Console.WriteLine("Digite a nota do primeiro bimestre:");
     n1 = int.Parse(Console.ReadLine()); 

    Console.WriteLine("Digite a nota do segundo bimestre:");
     n2 = int.Parse(Console.ReadLine()); 
    
    int s1 = (((n1*2) + (n2*3))/ (2 + 3));
     Console.WriteLine($"A média do primeiro semestre é: {s1}");
 
  }

}