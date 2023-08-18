namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int rows, space,totalrows;
         Console.Write ("Enter an odd number:");
         totalrows  = int.Parse (Console.ReadLine ());
         rows = totalrows / 2 + 1;

         for (int i = 1; i <= rows; i++) {
            for (space = 1; space <= rows - i; space++) {
               Console.Write ("  ");
            }
            for (int j = 1; j <= 2 * i - 1; j++) {
               Console.Write ("* ");
            }
            Console.Write ("\n");
         }
         space = 1;
         for (int i = rows - 1; i >= 1; i--) {
            for ( space = 1; space <= rows-i; space++) {
               Console.Write ("  ");
            }
            for (int j = 1; j <= 2*i-1; j++) {
               Console.Write ("* ");
            }
            Console.Write ("\n");
         }
      }
   }
}