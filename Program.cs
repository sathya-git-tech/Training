// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to ask the user for the number and
// Calculate the absolute value of a given number(x).
// If the number is positive, its absolute value is the same number (x).
// If it is negative, its absolute value is -x. 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Find the absolute value</summary>
   internal class Program {
      static void Main (string[] args) {
         for (; ; ) {
            Console.Write ("Enter a number : ");
            int number = int.Parse (Console.ReadLine ());
            number = Math.Abs (number);
            Console.WriteLine ($"Absolute value is : {number}");
         }
      }
   }
   #endregion 
}