namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number1:");
         int num1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number2:");
         int num2 = int.Parse (Console.ReadLine ());
         Console.WriteLine ($"Addition :{num1 + num2}");
         Console.WriteLine ($"Subraction : {num1 - num2}");
         Console.WriteLine ($"Multiplication : {num1 * num2}");
         Console.WriteLine ($"Division : {num1 / num2}");
         Console.WriteLine ($"Modulodivision :{num1 % num2}");
      }
   }
}