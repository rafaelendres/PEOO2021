using System;

class MainClass {
  public static void Main (string[] args) {
   
  double s = double.Parse(Console.ReadLine());
  double sal = 0;
    double rea = 0;
    if ((s > 0.00) && (s <= 400))
     rea = s * 0.15;
     sal = s + rea;
      Console.WriteLine($"Novo salario: {sal:0.00}");
      Console.WriteLine($"Reajuste ganho: {rea:0.00}");
      Console.WriteLine($"Em percentual: 15%");
    
    if ((s >= 400.01) && (s <= 800.00))
     rea = s * 0.12;
     sal = s + rea;
      Console.WriteLine($"Novo salario: {sal:0.00}");
      Console.WriteLine($"Reajuste ganho: {rea:0.00}");
      Console.WriteLine($"Em percentual: 12%");
     
    if ((s >= 800.01) && (s <= 1200.00))
     rea = s * 0.10;
     sal = s + rea;
      Console.WriteLine($"Novo salario: {sal:0.00}");
      Console.WriteLine($"Reajuste ganho: {rea:0.00}");
      Console.WriteLine($"Em percentual: 10%");
    
    if ((s >= 1200.01) && (s <= 2000))
     rea = s * 0.7;
     sal = s + rea;
      Console.WriteLine($"Novo salario: {sal:0.00}");
      Console.WriteLine($"Reajuste ganho: {rea:0.00}");
      Console.WriteLine($"Em percentual: 7%");
    
    if (s >=2000.01) 
     rea = s * 0.4;
     sal = s + rea;
      Console.WriteLine($"Novo salario: {sal:0.00}");
      Console.WriteLine($"Reajuste ganho: {rea:0.00}");
      Console.WriteLine($"Em percentual: 4%");
     
  }
}
