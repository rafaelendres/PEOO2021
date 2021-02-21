using System;
  class MainClass {
   public static void Main (){
     int x = 30;
     int y = 10; 
     int w = 0;
     Console.WriteLine($"MMC = {w}");
   }
    public static int MMC(int x, int y){
    int w = x % 2;
    return w;
    }
  }