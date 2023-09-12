namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a word:");
         string word = Console.ReadLine ();
         string result = string.Empty;
         for (int i = 0; i < word.Length; i++) {
            if (result.Contains (word[i])) break;
            else result += word[i];
         }
         Console.WriteLine (word.Length == result.Length ? $"Input string '{result}' is an isogram." : $"Input string '{result}' is not an isogram.");
      }
   }
}