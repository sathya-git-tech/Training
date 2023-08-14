using System;
namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number:");
         int n = int.Parse (Console.ReadLine ());
         for (int i = 2; i < n; i++) {
            if (n % i == 0) {
               Console.WriteLine ($"{n} is not Prime");
               i = i + 1;
               break;
            } if(n % i == 1) {
               Console.WriteLine ($"{n} is Prime");
               i = i + 1;
               break;
            }
         }
      }
   }
}