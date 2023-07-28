namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int n, k;
         n = new Random ().Next (1, 100);
          for (; ; ) {
            Console.Write ("Enter value for k:"); 
            bool var = int.TryParse (Console.ReadLine (),out k );
            if (var == false)
               Console.WriteLine ("invalid number");
            else {
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
}