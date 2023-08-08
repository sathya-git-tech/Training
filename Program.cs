namespace Training {
   internal class Program {
      static void Main (string[] args) {
          
         Console.Write ("Enter a number n:");
         int n = int.Parse (Console.ReadLine ());
         int a = 0;
         int b = 1;
         int c = a + b;
         for(int i = 2; i < n; i++) {
            c = a + b;
            a = b;
            b = c;
         }
         Console.WriteLine ($"Fabionacci of {n} is {c}"); 
      }
   }
}