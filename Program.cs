// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to ask the user for a number and display its multiplication table. 
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>Multiplication Table</summary>
   internal class Program {
      #region Method ------------------------------------------------
      /// <summary>Gettting input from the user</summary>
      /// <param name="args">n</param>
      static void Main (string[] args) {
         Console.Write ("Enter a number : ");
         int n = int.Parse (Console.ReadLine ());
         for (int i = 1; i <= 20; i++) {
            Console.WriteLine ($"{i,2}" + " *  " + n + " = " + (i * n));
         }
      }
   }
   #endregion
}
#endregion