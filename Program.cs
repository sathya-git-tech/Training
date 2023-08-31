namespace Training {
   internal class Program {
      static void Main (string[] args) {
         // swap a given number
         Console.Write ("Enter a number a:");
         int a = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number b:");
         int b = int.Parse (Console.ReadLine ());

         int temp = a;
         a = b;
         b = temp;
         Console.WriteLine ($"a={a},b={b}");
      }
   }
}