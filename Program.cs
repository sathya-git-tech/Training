namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a number:");
         int x = int.Parse (Console.ReadLine ());
         int total = 0;

         while (x > 0) {
            total +=  (x % 10);
            x /= 10;
         }
         Console.WriteLine ($"Digital root is: {total}");
      }
   }
}