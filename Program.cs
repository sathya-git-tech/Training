namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number:");
         int n = int.Parse (Console.ReadLine ());
         int f = 1;

         for(int i = 1; i <= n; i++) {
            f = f * i;
         }Console.WriteLine ($"factorial of {n} is {f}");
      }
   }
}