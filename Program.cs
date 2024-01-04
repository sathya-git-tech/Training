namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number1:");
         int num1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number2:");
         int num2 = int.Parse (Console.ReadLine ());
         Console.WriteLine ($"addition :{num1 + num2}");
         Console.WriteLine ($"subraction : {num1 - num2}");
         Console.WriteLine ($"multiplication : {num1 * num2}");
         Console.WriteLine ($"division : {num1 / num2}");
         Console.WriteLine ($"modulodivision :{num1 % num2}");
      }
   }
}