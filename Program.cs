// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Create a C# program to ask the user for 5 numbers,
// store them in an array and show them in reverse order.  
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Reverse order</summary>
   internal class Program {
      static void Main (string[] args) {
         int[] n = new int[5];
         for (; ; ) {
            Console.Write ("Enter a number : ");
            int value = int.Parse (Console.ReadLine ());
            int remainder = 0;
            while (value > 0) {
               remainder = ((remainder * 10) + value % 10);
               value /= 10;
            }
            Console.WriteLine ($"{remainder}");
         }
      }
   }
}
#endregion