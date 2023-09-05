namespace Training {
   internal class Program {
      static void Main (string[] args) {
         // swap a given number
         Console.Write ("Enter a number a:");
         int a = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number b:");
         int b = int.Parse (Console.ReadLine ());
          (a, b) = (b, a);
         Console.WriteLine ($"a={a},b={b}");
      }
   }
}