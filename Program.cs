// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- CUILib ---
// Program.cs
// Read the contents of the file input.txt programmatically and change the value of Mango, papaya and Bananana from fruit to vegetable and value of orange from fruit to color.
// Print the contents in the console and save to a file named out.txt.
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>Simple basic Assignment</summary>
   internal class Program {
      static void Main (string[] args) {
         string[] input = File.ReadAllLines ("C:\\Users\\sathya.k\\Downloads\\input.txt");
         for (int i = 0; i < input.Length; i++) {
            if (input[i].Contains ("Mango") || input[i].Contains ("Bananana") || input[i].Contains ("Papaya")) {
               input[i] = input[i].Replace ("Fruit", "Vegetable");
            }
            if (input[i].Contains ("Orange")) Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine (input[i]);
            Console.ResetColor ();
         }
      }
   }
   #endregion 
}
