namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int length = 6;
         Random random = new ();
         int[] randomNumbers = new int[6];
         for (int i = 0; i < length; i++) randomNumbers[i] = random.Next (1, 101);
         Console.WriteLine ("Random Array: " + string.Join (" ", randomNumbers));
         Console.Write ("Enter the first index number: ");
         if (int.TryParse (Console.ReadLine (), out int index1) && index1 >= 0 && index1 < length) {
            Console.Write ("Enter the second index number: ");
            if (int.TryParse (Console.ReadLine (), out int index2) && index2 >= 0 && index2 < length) {
               (randomNumbers[index1], randomNumbers[index2]) = (randomNumbers[index2], randomNumbers[index1]);
               Console.WriteLine ("Swapped result: " + string.Join (" ", randomNumbers));
            } 
            else Console.WriteLine ("Invalid second index number");
         } 
         else Console.WriteLine ("Invalid first index number");
      }
   }
}