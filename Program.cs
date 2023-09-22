namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a word:");
         string word = Console.ReadLine ();
         string result = string.Empty;
         for (int i = 0; i < word.Length; i++) {
            if (result.Contains (word[i])) break;
         }
         Console.WriteLine (word.Length == result.Length ? $"Input string '{word}' is an isogram." : $"Input string '{word}' is not an isogram.");
      }
   }
}