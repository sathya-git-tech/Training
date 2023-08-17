using System;
namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number n:");
         int n = int.Parse (Console.ReadLine ());
         bool prime = true;
         for (int i = 2; i < n/2; i++) {
            if (n % i == 0) {
               Console.WriteLine ("is not prime");
               prime = false;
               break;
            }
         }
         if (prime == true) {
            Console.WriteLine ("is prime");
         }
      }
   }
}