using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite 4 valores inteiros:");
    String[] valores = Console.ReadLine().Split(' ');
    int A = int.Parse(valores[0]);
    int B = int.Parse(valores[1]);
    int C = int.Parse(valores[2]);
    int D = int.Parse(valores[3]);
    if B > C && D > A &&  ((C + D) > (A+B)) && (C > 0) && (D > 0) && (A % 2 = 0))
    Console.WriteLine("Valores aceitos");
    else Console.WriteLine("Valores nao aceitos");

  }
}

