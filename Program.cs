// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Spelling bee frequency
// Use the same word list given in the Spelling Bee assignment and build a frequency table with occurrence of all the letters.
// The output should be a list of a letters with its occurrence count in descending order. Display the first 7 letters to be used as the seed for the Spelling Bee program.
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary> Spelling bee frequency </summary
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary> The program can assume a word list is given as a text file </summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
         Dictionary<char, int> freq = new ();
         foreach (var ch in File.ReadAllText ("C:\\Users\\sathya.k\\Downloads\\words.txt"))
            if (ch is >= 'A' and <= 'Z') freq[ch] = freq.ContainsKey (ch) ? freq[ch] + 1 : 1;
         foreach (var item in freq.OrderByDescending (x => x.Value).Take (7)) Console.WriteLine ($"{item}");
      }
   }
   #endregion 
}
#endregion