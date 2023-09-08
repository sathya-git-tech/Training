using System.Text;
namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a string:");
         string input = Console.ReadLine ().ToLower ();
         int l = input.Length;
         StringBuilder result = new ();
         for (int i = 0; i < l; i++) {
            if (i == l - 1 || input[i] != input[i + 1]) result.Append (input[i]);
            else i++;
         }
         Console.WriteLine (result.Length == 0 ? "Reduced string is 'Empty'" : $"Reduced string is '{result}'");
      }
   }
}