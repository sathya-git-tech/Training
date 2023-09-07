namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a string:");
         string input = Console.ReadLine ();
         char[] character = input.ToArray ();
         input = input.ToLower ();
         for (int i = 0; i < input.Length; i++) {
            string result = string.Empty;
            if (i == input.Length - 1 || input[i] != input[i + 1]) {
               result += input[i];
               Console.Write (result);
            }
            else i++;
         }
      }
   }
}