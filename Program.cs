// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Create a program to write on screen the numbers from 10 to 100.
// That are multiples of 3 and also multiples of 5. 
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>The number 10 to 100 that are multiples of 3 and 5</summary>
   internal class Program {
      static void Main (string[] args) {
         for (int i = 10; i <= 100; i++)
            if (i % 3 == 0 && i % 5 == 0) Console.WriteLine (i);
      }
   }
   #endregion 
}