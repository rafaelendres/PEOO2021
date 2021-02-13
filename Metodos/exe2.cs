using System;

  class MainClass {
    public static void Ordenar(ref int x, ref int y, ref int z){
     int maior, menor, med;
    
     if ((x>y) && (x>z)) maior = x; 
     if ((y>x) && (y>z)) maior = y; 
     if ((z>y) && (z>x)) maior = z; 
     
     if ((x>y) && (x<z)) med = x;
     if ((y>x) && (y<z)) med = y;
     if ((z>y) && (z<x)) med = z;
     
     if ((x<y) && (x<z)) menor = x;
     if ((y<x) && (y<z)) menor = y;
     if ((z<y) && (z<x)) menor = z; 

    }
    public static void Main (string[] args) {

       int x = int.Parse(Console.ReadLine());
       int y = int.Parse(Console.ReadLine());
       int z = int.Parse(Console.ReadLine());
       Ordenar(ref x, ref y, ref z);
      Console.WriteLine($"Maior = {maior}\n Mediano = {med}\n Menor = {menor}");
    }
  }