namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a number:");
         int n = int.Parse (Console.ReadLine ());

         for (int i = 1; i <= n * 2 - 1; i++) {
            int spaces = Math.Abs (n - i);
            int stars = (n * 2) - 1 - (2 * spaces);
            Console.WriteLine (string.Concat (Enumerable.Repeat (" ", spaces)) + string.Concat (Enumerable.Repeat ("*", stars)));
         }
      }
   }
}