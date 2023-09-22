namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number : ");
         int number = int.Parse (Console.ReadLine ());
         Console.WriteLine ($"{number}th armstrong number is : " + NthArmstrong (number));
      }
      static int NthArmstrong (int n) {
         int count = 0;
         for (int i = 1; i <= int.MaxValue; i++) {
            int num = i, rem, sum = 0;
            num = i;
            int length = num.ToString ().Length;
            while (num > 0) {
               rem = num % 10;
               sum += (int)Math.Pow (rem, length);
               num = num / 10;
            }
            if (i == sum)
               count++;
            if (count == n)
               return i;
         }
         return n;
      }
   }
}