// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Read the contents of the file input.txt programmatically and change the value of Mango, papaya and Bananana from fruit to vegetable and value of orange from fruit to color.
// Print the contents in the console and save to a file named out.txt.
// ---------------------------------------------------------------------------------------
using System.Reflection;
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>Simple basic Assignment</summary>
   internal class Program {
      static void Main (string[] args) {
         using var stream = Assembly.GetExecutingAssembly ().GetManifestResourceStream ("Training.data.input.txt");
         using var reader = new StreamReader (stream);
         using var writer = new StreamWriter ("..\\..\\..\\data\\output.txt");
         var input = new List<string> ();
         while (!reader.EndOfStream)
            input.Add (reader.ReadLine ());
         for (int i = 0; i < input.Count; i++) {
            if (input[i].Contains ("Mango") || input[i].Contains ("Bananana") || input[i].Contains ("Papaya")) {
               input[i] = input[i].Replace ("Fruit", "Vegetable");
            }
            if (input[i].Contains ("Orange")) input[i] = input[i].Replace ("Fruit", "Color");
            Console.WriteLine (input[i]);
            writer.WriteLine (input[i]);
         }
      }
   }
   #endregion 
}
