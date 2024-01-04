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
      static void Main () {
         using var stream = Assembly.GetExecutingAssembly ().GetManifestResourceStream ("Training.data.input.txt");
         using var reader = new StreamReader (stream);
         using var writer = new StreamWriter ("..\\..\\..\\data\\output.txt");
         string output = reader.ReadToEnd ();
         var lines = output.Split ('\n').ToList ();
         Dictionary<string, string> replacements = new ();
         foreach (var i in lines) {
            lines = i.Split ('=').ToList ();
            switch (lines[0]) {
               case "Mango":
               case "Banana":
               case "Papaya":
                  replacements.Add (lines[0], "Vegetable");
                  break;
               case "Orange":
                  replacements.Add (lines[0], "Color");
                  break;
               default:
                  replacements.Add (lines[0], lines[1]);
                  break;
            }
         }
         foreach (var keyValuePair in replacements) {
            Console.WriteLine ($"{keyValuePair.Key}={keyValuePair.Value}", $"{keyValuePair.Key}={keyValuePair.Value}");
            writer.Write ($"{keyValuePair.Key}={keyValuePair.Value}", $"{keyValuePair.Key}={keyValuePair.Value}");
         }
      }
   }
   #endregion 
}
