using System;

class MainClass {
  public static void Main (string[] args) {
    int s = 0;
    Console.WriteLine("Informe os números");
     int num = int.Parse(Console.ReadLine());
    while ((num >= 1) && (num <=200) && (num != 0))  
     s = (s + num);
      if ((s / s == 1) && ( s / 1 == s))     Console.WriteLine("Prime");   
       else Console.WriteLine("Not Prime");
  }
}