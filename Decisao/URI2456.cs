using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Insira 5 cartas de valores inteiros:");
    String[] ct = Console.ReadLine().Split(' ');
    int a = int.Parse(ct[0]);
    int b = int.Parse(ct[1]);
    int c = int.Parse(ct[2]);
    int d = int.Parse(ct[3]);
    int e = int.Parse(ct[4]);

    if ((a <= b) && (b <= c) && (c <= d) && (d <= e ))Console.WriteLine("C");
    if ((a >= b) && (b >= c) && (c >= d) && (d >= e ))Console.WriteLine("D");
  else Console.WriteLine("N");


  }
} 