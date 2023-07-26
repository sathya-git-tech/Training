namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int n, k;
         n = new Random ().Next (1, 100);
         Console.Write ("Enter value for k:");
         for (int i = 1; i < 9; i++) {
            k = int.Parse (Console.ReadLine ());
            if (n < k)
               Console.WriteLine ("you guess is too high");
            else if (n > k)
               Console.WriteLine ("you guess is too low");
            else {
               Console.WriteLine ("you guessed correctly");
               break;
            }
         }
      }
   }
}