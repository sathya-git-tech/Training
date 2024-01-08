// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to ask the user for an undetermined amount of numbers (until 0 is entered) and display their sum (using do...while). 
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>A program to ask the user for an undetermined of numbers and display their sum</summary>
   internal class Program {
      #region Method ------------------------------------------------
      /// <summary>Getting input from the user</summary>
      /// <param name="args">number</param>
      static void Main (string[] args) {
         Console.WriteLine ("Enter a number : ");
         int number = int.Parse (Console.ReadLine ());
         int total = 0;
         do {
            total += (number % 10);
            number /= 10;
         }
         while (number > 0);
         Console.WriteLine ($"Sum is : {total}");
      }
   }
   #endregion 
}
#endregion