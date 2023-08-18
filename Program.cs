namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a number:");
         int n = int.Parse (Console.ReadLine ());
         int remainder = 0;
         while(n>0) {
            remainder = ((remainder * 10) + n % 10);
            n /= 10;
         }
         Console.WriteLine ($"{remainder}");
      }
   }
}