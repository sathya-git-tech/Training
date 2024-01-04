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
         var dict = output.Split ('\n').Select (a => a.Split ('=')).ToDictionary (a => a[0], a => a[1]);
         dict["Mango"] = dict["Banana"] = dict["Papaya"] = "Vegetable";
         dict["Orange"] = "Color";
         foreach (var kv in dict) {
            var s = $"{kv.Key}={kv.Value}";
            Console.WriteLine (s);
            writer.WriteLine (s);
         }
      }
   }
   #endregion 
}
