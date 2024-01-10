// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to ask the user for a number;if it is not zero, then it will ask for a
// Second number and display the multiplication result like "3 * 2 = 6";
// Otherwise, it will display "0". 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Simble basic Assignment</summary>
   internal class Program {
      static void Main (string[] args) {
         for (; ; ) {
            Console.Write ("Enter a number : ");
            int num1 = int.Parse (Console.ReadLine ());
            if (num1 != 0) {
               Console.Write ("Enter a number : ");
               int num2 = int.Parse (Console.ReadLine ());
               Console.WriteLine ($"{num1} * {num2} = {num1 * num2}");
            } else Console.WriteLine ("0");
         }
      }
   }
   #endregion
}