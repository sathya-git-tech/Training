// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Create a program to ask the user for a number "x" and display 10 * x.
// It must repeat until the user enters 0 (using "while"). 
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>The program to ask the user for a number "x" and display 10 * x</summary>
   internal class Program {
      #region Method ------------------------------------------------
      /// <summary>Getting input from the user</summary>
      /// <param name="args">x</param>
      static void Main (string[] args) {
         while (true) {
            Console.Write ("Enter a number : ");
            int x = int.Parse (Console.ReadLine ());
            if (x == 0) break;
            Console.WriteLine ($"10 * {x} = {10 * x}");
         }
      }
   }
   #endregion 
}
#endregion