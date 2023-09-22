namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("enter a number leaving space between them:");
         string[] numbers = Console.ReadLine ().Split (' ');
         Console.WriteLine ("Original position: " + string.Join (" ", numbers));
         Console.Write ("Enter the first index to be swapped (0-5): ");
         int index1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter the second index to be swapped (0-5): ");
         int index2 = int.Parse (Console.ReadLine ());
         (numbers[index1], numbers[index2]) = (numbers[index2], numbers[index1]);
         Console.WriteLine ("Swapped result: " + string.Join (" ", numbers));
      }
   }
}