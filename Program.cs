// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to get a number from the user and answer whether
// It is positive or negative. 
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>Positive or negative</summary>
   internal class Program {
      #region Method ------------------------------------------------
      /// <summary>Getting input from the user</summary>
      /// <param name="args">n</param>
      static void Main (string[] args) {
         Console.Write ("Enter a number : ");
         int n = int.Parse (Console.ReadLine ());
         Console.WriteLine (n > 0 ? $"The number {n} is positive" : $"The number {n} is negative");
      }
   }
   #endregion 
}
#endregion