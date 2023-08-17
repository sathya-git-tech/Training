namespace Training {
   internal class Program {
      static void Main (string[] args) {
         // Fabionacci series
         Console.Write ("Enter a number n:");
         int n = int.Parse (Console.ReadLine ());
         int first = 0;
         int second = 1;
         int third = first + second; 
         for(int i =2; i < n; i++) {
            third = first + second;
            first = second;
            second = third;
         }
         Console.WriteLine ($"Fabionacci of {n} is {third}"); 

      }
   }
}