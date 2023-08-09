namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int num1, num2, max, min, LCM, GCD;
         Console.Write ("Enter a number num1:");
         num1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number num2:");
         num2 = int.Parse (Console.ReadLine ());

         max = num1 > num2 ? num1 : num2;
         min = num1 < num2 ? num1 : num2;
         while (true) {
            if(max % num1==0 && max % num2 == 0) {
               LCM = max;
               break;
            }
            max++;
         }
         while (min >= 2) {
            if(num1 % min==0 && num2 % min == 0) {
               GCD = min;
               break;
            }
            min--;
         }
         Console.WriteLine ($"LCM is {max}");
      }
   }
}