namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number:");
         int n = int.Parse (Console.ReadLine ());
         int result = 0;
         for (int i = 2; i < n; i++) {
            if (n % i == 0) {
               result = 1;
               break;
            }
         }
         if (result == 0) {
            Console.WriteLine ($"{n} is Prime");
         } else {
            Console.WriteLine ($"{n} is not prime");
         }
      }
   }
}