namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter the total count of numbers: ");
         int Total = int.Parse (Console.ReadLine ());
         float Average; int Sum = 0, Value;
         for (int i = 0; i < Total; i++) {
            Console.Write ("Enter a number: ");
            Value = int.Parse (Console.ReadLine ());
            Sum += Value;
         }
         Average = (float)Sum / Total;
         Console.WriteLine ("Average: " + Average);
      }
   }
}