// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Create a program to display on the screen the odd numbers from  50 to 1 (downwards), using "while" 
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>Create a program to display on the screen the odd numbers from  50 to 1 (downwards)</summary>
   internal class Program {
      static void Main (string[] args) {
         int n = 50;
         while (n >= 1) {
            if (n % 2 != 0) Console.WriteLine (n);
            n--;
         }
      }
   }
   #endregion
}