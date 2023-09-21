namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("enter a words leaving space between them:");
         string[] words = Console.ReadLine ().Split (' ');
         string longestWord = FindLongestAbecedarianWord (words);
         Console.WriteLine (!string.IsNullOrEmpty (longestWord) ? $"The longest abecedarian word is : {longestWord}" : "No abecedarian word");
      }

      static string FindLongestAbecedarianWord (string[] words) {
         string longestWord = "";
         foreach (string eachWord in words) {
            char[] chars = eachWord.ToCharArray ();
            Array.Sort (chars);
            if (eachWord == new string (chars) && eachWord.Length >= longestWord.Length) {
               longestWord = eachWord;
            }
         }
         return longestWord;
      }
   }
}

