namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number: ");
         if (int.TryParse (Console.ReadLine (), out int number)) {
            if (number >= 1 && number <= 25) {
               int nthArmstrong = FindNthArmstrong (number);
               Console.WriteLine ($"{number}th Armstrong number is: {nthArmstrong}");
            } else Console.WriteLine ("Please enter the number between 1 to 25");
         } else Console.WriteLine ("Invalid input. Please provide a valid integer.");
      }
      static int FindNthArmstrong (int n) {
         int count = 0;
         for (int i = 1; ; i++) {
            int num = i, rem, sum = 0;
            int length = num.ToString ().Length;
            while (num > 0) {
               rem = num % 10;
               sum += (int)Math.Pow (rem, length);
               num = num / 10;
            }
            if (i == sum) count++;
            if (count == n) return i;
         }
      }
   }
}