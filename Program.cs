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
         char[] letters = { 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N' };
         for (int i = 0; i < letters.Length; i++)
            Console.WriteLine (letters[i]);
      }
   }
   #endregion 
}
