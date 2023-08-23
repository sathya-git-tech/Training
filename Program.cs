namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number:");
         int n = int.Parse (Console.ReadLine ());
         for(int i = 1; i <= n; i++) {
            Console.WriteLine ($"{i,2}" + " *  " + 3 + " = " + (i * 3));
         }
      }
   }
}