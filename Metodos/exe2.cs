using System;

  class MainClass {
   
    public static void Main (string[] args) {
       int x = 1;
       int y = 5;
       int z = 3;
      
    }

    public static void Ordenar(ref int x, ref int y, ref int z) {
       
         int aux;
      
         if (x > y) {
           aux = x;
           x = y;
           y = aux;
        }

         if (x > z) {
           aux = x;
           x = z;
           z = aux;
        }

         if (y > z) {
           aux = y;
           y = z;
           z = aux;
        } 

       Console.WriteLine(x);
       Console.WriteLine(y);
       Console.WriteLine(z);
        
    }   
  }
   