namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int rows, space;
         Console.Write ("Enter a number:");
         rows  = int.Parse (Console.ReadLine ());

         // build upper half of the diamond pattern

         for (int i = 0; i <= rows; i++) {
            string pattern = string.Empty;
            for (space = 1; space <= rows - i; space++) {
               pattern += "  ";
            }
            for (int j = 0; j <=i; j++) {
               pattern += "* ";
            }
            for (int j = 1; j <= i; j++) {
               pattern += "* ";
            }
            Console.Write ($"\n{pattern}");
         }



         // build lower half of the diamond pattern

         space = 1;
         for (int i = rows - 1; i >= 0; i--) {
            string pattern = string.Empty;
            for ( space = 1; space <= rows-i; space++) {
               pattern += "  ";
            }
            for (int j = 0; j <=i; j++) {
               pattern += "* ";
            }
            for (int j = 1; j <= i; j++) {
               pattern += "* ";
            }
            Console.Write ($"\n{pattern}");
         }
      }
   }
}