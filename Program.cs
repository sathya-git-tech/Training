namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int rows, space,a=1;
         Console.Write ("Enter a number:");
         rows = int.Parse (Console.ReadLine ());
         
         a = 1;
         for (int i = 0; i < rows; i++) {
            for (space = 1; space <= rows - i; space++) {
               Console.Write ("  ");
            }
            for (int j = 0; j < i+1; j++) {
               if (j > 0) { 
                  a = a * (i - j + 1) / j;
               }
               Console.Write ($"{a,-3} ");
            }
            Console.Write ("\n");
         }
      }
   }
}