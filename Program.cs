// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to print the even numbers from 2 to 50, except 20.
// You need to write this program in 3 different ways:
// Incrementing 2 in each step (use "continue" to skip 16).
// Incrementing 1 in each step (use "continue").
// Endless loop using "break" & "continue".
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Print even numbers 2 to 50 (except 20)</summary>
   internal class Program {
      static void Main (string[] args) {
         int i = 2;
         // Print the even numbers from 2 to 50, except 20.
         Console.WriteLine ("Print the even numbers from 2 to 50, except 20.");
         for (i = 2; i <= 50; i += 2) {
            if (i == 20) continue;
            Console.WriteLine (i);
         }
         // Incrementing 2 in each step (use "Continue" to skip 16).
         Console.WriteLine ("Incrementing 2 in each step");
         for (i = 2; i <= 50; i += 2) {
            if (i == 16) continue;
            Console.WriteLine (i);
         }
         // Incrementing 1 in each step (use "continue").
         Console.WriteLine ("Incrementing 1 in each step");
         for (i = 2; i <= 50; i++) {
            if (i == 20) continue;
            Console.WriteLine (i);
         }
      }
   }
   #endregion
}