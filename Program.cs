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
         Console.Write ("Enter a number : ");
         string input = Console.ReadLine ();
         if (double.TryParse (input, out double value)) {
            double absoluteValue = (value < 0) ? -value : value;
            Console.WriteLine ($"Absolute value of {input} is {absoluteValue}");
         } else Console.WriteLine ("Invalid input. Please enter a valid number");
      }
   }
   #endregion 
}