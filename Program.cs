namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int num1, num2;
         Console.Write ("Enter a number num1:");
         if (int.TryParse (Console.ReadLine (), out num1) && num1 > 0) {
            Console.Write ("Enter a number num2:");
            if (int.TryParse (Console.ReadLine (), out num2) && num2 > 0) {
               int gcd = GCD (num1, num2);
               int lcm = LCM (num1, num2);

               Console.WriteLine ($"GCD of {num1} and {num2}: {gcd}");
               Console.WriteLine ($"LCM of {num1} and {num2}: {lcm}");
            } else {
               Console.WriteLine ("Invalid input. Please enter a positive integer for the second number.");
            }
         } else {
            Console.WriteLine ("Invalid input. Please enter a positive integer for the first number.");
         }
      }
      static int GCD (int a, int b) {
         while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
         }
         return a;
      }
      static int LCM (int a, int b) {
         return (a * b) / GCD (a, b);
      }
   }
}