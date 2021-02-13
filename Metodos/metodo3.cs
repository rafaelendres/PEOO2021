using System;

  class MainClass {
public static void Metodo3(out int a, out int b) {
a = 10;
b = 20;
}
public static void Main (string[] args) {
int x, y;
Metodo3(out x, out y);
Console.WriteLine($"{x} e {y}");
}
  }