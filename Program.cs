namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a number:");
         int n = int.Parse (Console.ReadLine ());

         for(int i = 1; i <= n; i++) {
            Console.WriteLine (string.Concat (Enumerable.Repeat ("  ", n - i)) + string.Concat (Enumerable.Repeat ("* ", 2 * i - 1)));
         }
         for(int i = n - 1; i >= 1; i--) {
            Console.WriteLine (string.Concat (Enumerable.Repeat ("  ", n - i)) + string.Concat (Enumerable.Repeat ("* ", 2 * i - 1)));
         }
      }
   }
}