using System;

class MainClass {
  public static void Main (string[] args) {

  int x = int.Parse(Console.ReadLine());
  int y = int.Parse(Console.ReadLine());
  int aux = 0;
  while (x<=y)
  {
    aux += x;
    if (x % 13 == 0){
      aux += x;
    }
     x++;
  }
   Console.WriteLine($"{aux}");


   
  }
}