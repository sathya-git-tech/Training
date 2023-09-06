namespace Training {
   
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number:");
         int num = int.Parse (Console.ReadLine ());
         if (num == ArmstrongNum (num)) Console.WriteLine ($"{num} is armstrong");
         else Console.WriteLine ($"{num} is not armstrong");
      }
      static int ArmstrongNum (int n) {
         int length = n.ToString ().Length;
         int result = 0;
         while (n > 0) {
            int rem = n % 10;
            result += (int)Math.Pow (rem, length);
            n /= 10;
         }
         return result;
      }
   }
}





