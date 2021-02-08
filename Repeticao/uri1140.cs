using System;

class MainClass {
  public static void Main (string[] args) {

string frase = Console.ReadLine();
 while (frase != "*") {
   frase = frase.ToLower();
   char c = frase[0];
   bool ok = true;
   for (int i = 1; i < frase.Length; i++)
    if (frase[i] == ' ' && frase[i+1] != c) ok = false;
   if (ok) Console.WriteLine("Y");
   else Console.WriteLine("N");  
   frase = Console.ReadLine();
  }
  }
}