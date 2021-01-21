using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Insira seu nome completo");
    string[] n = Console.ReadLine().Split(' ');
    Console.WriteLine ($"Bem vindo ao C#, {n[0]}");
  }
}
