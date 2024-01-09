// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to ask the user for an undetermined amount of
// Numbers (until 0 is entered) and display their sum (using do...while). 
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>Ask the user for an undetermined of number and display their sum</summary>
   internal class Program {
      #region Method ------------------------------------------------
      /// <summary>Getting input from the user</summary>
      /// <param name="args">number</param>
      static void Main (string[] args) {
         for (; ; ) {
            int sum = 0, number;
            do {
               Console.Write ("Enter a number : ");
               number = Convert.ToInt32 (Console.ReadLine ());
               sum += number;
            } while (number != 0);
            Console.WriteLine ("Sum of the numbers : " + sum);
         }
      }
   }
   #endregion 
}
#endregion