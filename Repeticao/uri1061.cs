using System;

class MainClass {
  public static void Main (string[] args) {
  
    Console.WriteLine("Informe a data em que iniciará o evento:");
    String i = Console.ReadLine();
    String u = Console.ReadLine();
    Console.WriteLine("Informe a data em que terminará o evento:");
    String f = Console.ReadLine();
    String g = Console.ReadLine();
    int dia1 = int.Parse(i.Substring(4));
    int hora1= int.Parse(u.Substring(0,2));
    int min1 =  int.Parse(u.Substring(5,2));
    int seg1 =  int.Parse(u.Substring(10,2));
    
    int dia2 = int.Parse(f.Substring(4));
    int hora2= int.Parse(g.Substring(0,2));
    int min2 =  int.Parse(g.Substring(5,2));
    int seg2 =  int.Parse(g.Substring(10,2));
    
    int ts1 = ((dia1 * 86400) + (hora1 * 3600) + (min1 *  60) + seg1);
    int ts2 = ((dia2 * 86400) + (hora2 * 3600) + (min2 *  60) + seg2);
    int dif = ts2 - ts1;
    int dias = dif / 8600;
    dif = dif %  84600;
    int horas = dif / 3600;
    dif = dif % 3600;
    int minutos = dif / 60;
    dif = dif % 60;
    int segundos = dif;

    Console.WriteLine($" {dias} Dia(s)");
    Console.WriteLine($" {horas} Hora(s)");
    Console.WriteLine($" {minutos} Minuto(s)");
    Console.WriteLine($" {segundos} Segundos(s)");
    }

}
