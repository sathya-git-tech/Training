namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Welcome to the Guessing Game!");
         Console.WriteLine ("Think of a number between 1 and 100, and I'll try to guess it.");

         int min = 1;
         int max = 100;


         for (int tries=1; ;tries++) {
            int guess = (min + max) / 2;

            Console.WriteLine ($"\nIs your number {guess}?");
            Console.WriteLine ("1. Your guess is too high press key 1");
            Console.WriteLine ("2. Your guess is too low press key 2");
            Console.WriteLine ("3. You guessed correctly press key 3");

            int userResponse = GetUserResponse ();

            if (userResponse == 1) {
               max = guess - 1;
            } else if (userResponse == 2) {
               min = guess + 1;
            } else if (userResponse == 3) {
               Console.WriteLine ($" I guessed your number {guess} in {tries} attempts.");
               break;
            } else {
               Console.WriteLine ("Invalid input. Please select a valid option.");
            }
         }
      }

      static int GetUserResponse () {
         int response;
         if (!int.TryParse (Console.ReadLine (), out response) || response < 1 || response > 3) {
            Console.WriteLine ("Invalid input. Please choose 1, 2, or 3.");
         }
         return response;

      }
   }
        
   
}