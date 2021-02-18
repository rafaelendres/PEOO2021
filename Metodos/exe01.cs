using System;
  class MainClass {
   public static void Main (){
    double x = 10;
    double y = 20;
    double z = Maior(x, y);
    Console.WriteLine(z);
    Console.WriteLine(Maior(50, 20));
    Console.WriteLine(Maior(3760, 350));
   }
   
    public static double Maior(double x, double y){
        double a = x;
        if (y > x) a = y;
        return a;
      }
 }
