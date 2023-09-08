using System.Text;
namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a string:");
         string input = Console.ReadLine ();
         char[] character = input.ToArray ();
         input = input.ToLower ();
         StringBuilder result = new StringBuilder ();

         for (int i = 0; i < input.Length; i++) {
            if (i == input.Length - 1 || input[i] != input[i + 1]) {
               result.Append (input[i]);
            } 
            else i++;
         }
         Console.WriteLine (result.Length==0? "Reduced string is 'Empty'" : $"Reduced string is '{result}'");
      }
   }
}