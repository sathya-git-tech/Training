using System;
namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a Number n :");
         int n = int.Parse (Console.ReadLine ());
         Console.WriteLine ($"The number binary is : {Convert.ToString (n, 2)}");
         Console.WriteLine ($"The number Hexadecimal is : {Convert.ToString (n, 16)}");
      }
   }
}