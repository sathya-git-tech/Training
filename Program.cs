namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int length = 6;
         Random random = new Random ();
         int[] randomNumbers = new int[6];
         for (int i = 0; i < length; i++) {
            randomNumbers[i] = random.Next (1, 101);
         }
         Console.WriteLine ("Random Array: " + string.Join (" ", randomNumbers));
         Console.Write ("Enter the first index number: ");
         int index1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter the second index number: ");
         int index2 = int.Parse (Console.ReadLine ());
         (randomNumbers[index1], randomNumbers[index2]) = (randomNumbers[index2], randomNumbers[index1]);
         Console.WriteLine ("Swapped result: " + string.Join (" ", randomNumbers));
      }
   }
}