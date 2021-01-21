using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o intervalo de tempo no formato “HH:MM:SS");
    string[] hms = Console.ReadLine().Split(':');
    long h = long.Parse(hms[0]);
    long m = long.Parse(hms[1]);
    long s = long.Parse(hms[2]);
    long hs = h * 3600;
    long ms = m * 60;
    long vl = (s + hs + ms) * 300000;
    Console.WriteLine($"A distância percorrida é igual a: {vl}");
  }
}