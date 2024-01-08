// Write a program to calculate and display the average of four numbers entered by the user. 
namespace Training {
   internal class Program {
      static void Main (string[] args) {
         int[] total = new int[4];
         float average; 
         int sum = 0;
         for (int i = 0; i < total.Length; i++) {
            Console.Write ("Enter a number : ");
            int value = int.Parse (Console.ReadLine ());
            sum += value;
         }
         average = (float)sum / total.Length;
         Console.WriteLine ($"Average = {average}");
      }
   }
}