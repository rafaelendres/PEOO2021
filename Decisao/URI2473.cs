using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Informe os números que você escolheu");
    String[] n = Console.ReadLine().Split(' ');
    
    int a = int.Parse(n[0]);
    int b = int.Parse(n[1]);
    int c = int.Parse(n[2]);
    int d = int.Parse(n[3]);
    int e = int.Parse(n[4]);
    int f = int.Parse(n[5]);

    Console.WriteLine("Informe os números sorteados");
    String[] s = Console.ReadLine().Split(' ');

    int g = int.Parse(s[0]);
    int h = int.Parse(s[1]);
    int i = int.Parse(s[2]);
    int j = int.Parse(s[3]);
    int k = int.Parse(s[4]);
    int l = int.Parse(s[5]);
    
    int soma = 0;

    if ((a == g ) || (a == h) ||  (a == i) || (a == j) || (a == k ) || (a == l))
    soma+=1;
    if ((b == g ) || (b == h) ||  (b == i) || (b == j) || (b == k ) || (b == l))
    soma+=1;
    if ((c == g ) || (c == h) ||  (c == i) || (c == j) || (c == k ) || (c == l))
    soma+=1;
    if ((d == g ) || (d == h) ||  (d == i) || (d == j) || (d == k ) || (d == l))
    soma+=1;
    if ((e == g ) || (e == h) ||  (e == i) || (e == j) || (e == k ) || (e == l))
    soma+=1;
    if ((f == g ) || (f == h) ||  (f == i) || (f == j) || (f == k ) || (f == l))
    soma+=1;
    
    if (soma == 3 ) Console.WriteLine("Terno");  
    if (soma == 4 ) Console.WriteLine("Quadra");  
    if (soma == 5 ) Console.WriteLine("Quina");  
    if (soma == 6 ) Console.WriteLine("Sena");  
    else Console.WriteLine("Azar");
  
  }

}