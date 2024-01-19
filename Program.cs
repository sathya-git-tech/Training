// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to read the file and reverse all content and save it in another file
// With same name but the extension is "rev". 
// ---------------------------------------------------------------------------------------

using System.Reflection;
namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Write a program to read the file and reverse all content</summary>
   internal class Program {
      static void Main (string[] args) {
         using var stream = Assembly.GetExecutingAssembly ().GetManifestResourceStream ("Training.Data.words.txt");
         using var reader = new StreamReader (stream);
         using var writer = new StreamWriter ("..\\..\\..\\data\\words.rev");
         string words = reader.ReadToEnd ();
         char[] reversedchars = words.ToCharArray ();
         Array.Reverse (reversedchars);
         string reversedText = new (reversedchars);
         Console.WriteLine (reversedText);
         writer.WriteLine (reversedText);
      }
   }
   #endregion
}