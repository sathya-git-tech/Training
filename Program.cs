// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Spelling Bee
// Write a program to help solve a New-York Times style Spelling Bee. The program can assume a word list is given as a text file, and that the daily choice of 7 letters is provided as an array of 7 chars:
// char[] letters = { 'U', 'X', 'A', 'L', 'T', 'N', 'E' } 
// Your program should find all valid Spelling Bee words form the given dictionary:
// Each word is at least 4 letters long
// Each word uses only the 7 seed letters
// Each word MUST use the first letter (in this case, Y)
// Any letter can be used more than once
// The score is then computed like this:
// 4 letter words score 1 point
// Longer words score as many points as there are letters
// Any word that uses all 7 seed letters (called pangrams) gets an additional 7 bonus points
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary> Spelling Bee </summary
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary> The program can assume a word list is given as a text file </summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
         char[] seed = { 'U', 'X', 'L', 'T', 'A', 'E', 'N' };
         var words = File.ReadAllLines ("C:\\Users\\sathya.k\\Downloads\\words.txt")
            .Where (x => x.Length >= 4 && x.Contains (seed[0]) && x.All (seed.Contains));
         Dictionary<string, int> Valid = new ();
         foreach (var word in words) {
            int score = GetScore (word, seed);
            Valid.Add (word, score);
         }
         foreach (var w in Valid.OrderByDescending (w => w.Value).ThenBy (w => w.Key).ToList ()) {
            bool ispangram = (IsPangram (w.Key, seed));
            if (ispangram) Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ($"{w.Value,3}.{w.Key}");
            if (ispangram) Console.ResetColor ();
         }
         Console.WriteLine ($"----\n{Valid.Values.Sum ()} total");
      }
      /// <summary> Any letter can be used more than once the score will be increase </summary>
      /// <param name="word"> Text file </param>
      /// <param name="seed"> Characters </param>
      /// <returns> GetScore </returns>
      static int GetScore (string word, char[] seed) {
         if (word.Length == 4) return 1;
         else if (IsPangram (word, seed)) return word.Length + 7;
         else return word.Length;
      }
      /// <summary> Any word that uses all 7 seed letters called pangrams </summary>
      /// <param name="word"> Text file </param>
      /// <param name="seed"> Characters </param>
      /// <returns> IsPangram </returns>
      static bool IsPangram (string word, char[] seed) => seed.All (word.Contains);
   }
   #endregion 
}
#endregion
