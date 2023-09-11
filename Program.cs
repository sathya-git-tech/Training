namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a word:");
         string word = Console.ReadLine ();
         string result = string.Empty;
         for (int i = 0; i < word.Length; i++) {
            if (!result.Contains (word[i])) 
               result += word[i];
         }
         Console.WriteLine (word.Length == result.Length ? $"string is Isogram '{result}'" : $"string is not Isogram '{result}'");

      }
   }
}