using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe 3 valores inteiros");
    String[] n = Console.ReadLine().Split(' ');
    int a = int.Parse(n[0]);
    int b = int.Parse(n[1]);
    int c = int.Parse(n[2]);

    if (a > b && b > c) Console.WriteLine($" {c}\n {b}\n {a}\n{a}\n {b}\n {c}");
    if (a > c && c > b) Console.WriteLine($" {b}\n {c}\n {a}\n {a}\n {b}\n {c}");
    if (b > a && a > c) Console.WriteLine($" {c}\n {a}\n {b}\n {a}\n {b}\n {c}");
    if (b > c && c > a) Console.WriteLine($" {a}\n {c}\n {b}\n {a}\n {b}\n {c}");
    if (c > a && a > b) Console.WriteLine($" {a}\n {b}\n {c}\n {a}\n {b}\n {c}");
    if (c > b && b > a) Console.WriteLine($" {b}\n {a}\n {c}\n {a}\n {b}\n {c}");  
  
  }
  
} 

