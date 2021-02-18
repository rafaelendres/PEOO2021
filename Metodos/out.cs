using System;

class MainClass {
public static void Metodo3(out int a, out int b) {
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
}
public static void Main (string[] args) {
int x, y;
Metodo3(out x, out y);
Console.WriteLine($"Valor de A = {x} e valor de B =  {y}");

  }
} 