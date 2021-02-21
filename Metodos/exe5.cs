using System;
  
  class MainClass {
   public static void Main (){
  
    string texto = "LA LA LA LA";  
    Console.WriteLine(texto);
   }
   public static string FormatarTexto(string texto) {
    texto = texto.Trim();
    return texto;
   }
  }