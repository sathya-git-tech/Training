// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Create a program to write the letters "B" to "N" (uppercase), using "for".
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Print the letters "B" to "N" (uppercase)</summary>
   internal class Program {
      static void Main (string[] args) {
         for (char letter = 'B'; letter <= 'N'; letter++)
            Console.WriteLine (letter + " ");
      }
   }
   #endregion 
}
