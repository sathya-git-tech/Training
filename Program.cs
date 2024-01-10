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
            Console.Write ("Enter an alphabet (A-Z) or (a-z) : ");
            char ch = Convert.ToChar (Console.ReadLine ().ToLower ());
            if (char.IsDigit (ch) || ("!@#$%^&*()-+".Contains (ch)))
               Console.WriteLine ("You entered a number, please enter the alphabet.");
            else {
               switch (ch) {
                  case 'a':
                  case 'e':
                  case 'i':
                  case 'o':
                  case 'u':
                     Console.WriteLine ("The alphabet is vowel");
                     break;
                  default:
                     Console.WriteLine ("The alphabet is not a vowel");
                     break;
               }
            }
         }
      }
   }
   #endregion 
}