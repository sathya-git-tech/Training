namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Welcome to the Guessing Game!");
         Console.WriteLine ("Think of a number between 1 and 100, and I'll try to guess it.");

         int min = 1;
         int max = 100;


         for (int i = 0; i <= 7; i++) {
            int guess = (min + max) / 2;

            Console.WriteLine ($"\nIs your number {guess}?");
            Console.WriteLine ("1. Your guess is too high");
            Console.WriteLine ("2. Your guess is too low");
            Console.WriteLine ("3. You guessed correctly");

            int userResponse = GetUserResponse ();

            if (userResponse == 1) {
               max = guess - 1;
            } else if (userResponse == 2) {
               min = guess + 1;
            } else if (userResponse == 3) {
               Console.WriteLine ($" I guessed your number {guess} in {i} attempts.");
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