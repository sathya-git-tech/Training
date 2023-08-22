namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int rows, space;
         Console.Write ("Enter a number:");
         rows  = int.Parse (Console.ReadLine ());

         for (int i = 0; i <= rows; i++) {
            for (space = 1; space <= rows - i; space++) {
               Console.Write ("  ");
            }
            for (int j = 0; j <=i; j++) {
               Console.Write ("* ");
            }
            for (int j = 1; j <= i; j++) {
               Console.Write ("* ");
            }
            Console.Write ("\n");
         }
         space = 1;
         for (int i = rows - 1; i >= 0; i--) {
            for ( space = 1; space <= rows-i; space++) {
               Console.Write ("  ");
            }
            for (int j = 0; j <=i; j++) {
               Console.Write ("* ");
            }
            for (int j = 1; j <= i; j++) {
               Console.Write ("* ");
            }
            Console.Write ("\n");
         }
      }
   }
}