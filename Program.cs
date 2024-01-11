// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Create a program which asks the user for several numbers
// (until he enters "end" and displays their sum).
// When the execution is going to end,
// it must display all the numbers entered, and the sum again, as follows:
// Enter a number: 5 Sum = 5
// Enter a number: 3 Sum = 8 Enter a number: end The numbers are: 5 3 The sum is: 8
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Until he enters "end" and display their sum</summary>
   internal class Program {
      static void Main (string[] args) {
         List<int> numbers = new ();
         int sum = 0;
         while (true) {
            Console.Write ("Enter a number : ");
            string input = Console.ReadLine ();
            if (input.ToLower () == "end")
               break;
            if (int.TryParse (input, out int number)) {
               numbers.Add (number);
               sum += number;
               Console.WriteLine ($"Sum = {sum}");
            } else Console.WriteLine ("Invalid input. Please enter a valid number or 'end'.");
         }
         Console.Write ("The numbers are : ");
         foreach (int number in numbers) Console.Write ($"{number} ");
         Console.WriteLine ($"\nThe sum is = {sum}");
      }
   }
   #endregion
}