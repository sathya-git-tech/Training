// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Create a C# program to ask the user for a symbol and respond
// Whether it is a vowel (in lowercase), a digit, or any other symbol, using "switch". 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>The alphabet is vowel or not vowel</summary>
   internal class Program {
      static void Main (string[] args) {
         for (; ; ) {
            Console.Write ("Enter a symbol : ");
            char symbol = Convert.ToChar (Console.ReadLine ().ToLower ());
            switch (symbol) {
               case 'a':
               case 'e':
               case 'i':
               case 'o':
               case 'u':
                  Console.WriteLine ("The symbol is vowel");
                  break;
               case >= '0' and <= '9':
                  Console.WriteLine ("The symbol is digit");
                  break;

               default:
                  Console.WriteLine ("The symbol is neither a vowel nor a digit.");
                  break;
            }
         }
      }
   }
   #endregion 
}