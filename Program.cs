// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to print the even numbers from 2 to 50, except 20.
// You need to write this program in 3 different ways:
// Incrementing 2 in each step (use "continue" to skip 20).
// Incrementing 1 in each step (use "continue").
// Endless loop using "break" & "continue".
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program ---------------------------------------------------------------------
   /// <summary>Print even numbers 2 to 50 (except 20)</summary>
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Incrementing 2 in each step (use \"continue\" to skip 20) .");
         for (int i = 2; i <= 50; i += 2) {
            if (i == 20) continue;
            Console.WriteLine (i);
         }
         Console.WriteLine ("Incrementing 1 in each step use \"continue\" .");
         for (int i = 2; i <= 50; i++) {
            if (i == 20) continue;
            if (i % 2 == 0) Console.WriteLine (i);
         }
         int j = 2;
         Console.WriteLine ("Endless loop using \"break\" & \"continue\" .");
         while (true) {
            if (j > 50) break;
            if (j == 20) {
               j += 2;
               continue;
            }
            Console.WriteLine (j);
            j += 2;
         }
      }
   }
   #endregion
}