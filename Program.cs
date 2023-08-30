namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int n, number, rem, Arm;
         Console.Write ("Enter a number:");
          n = int.Parse (Console.ReadLine ());
          number = n; 
          rem = 0;
          Arm = 0;

         while (n > 0) {
            rem = n % 10;
            Arm = Arm + (rem * rem * rem);
            n /= 10;
         }
         if (number == Arm) {
            Console.WriteLine ($"{number} is Armstrong");
         } else {
            Console.WriteLine ($"{number} is not Armstrong");
         }
      }
   }
}