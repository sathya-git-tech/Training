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
         int i;
         int[] a = new int[5];
         for (i = 0; i < a.Length; i++) {
            Console.Write ("Enter a number : ");
            a[i] = Convert.ToInt32 (Console.ReadLine ());
         }
         Console.Write ("Original order : ");
         for (i = 0; i < 5; i++) Console.Write ("{0}  ", a[i]);
         Console.WriteLine ("\n");
         Console.Write ("Reverse order : ");
         for (i = a.Length - 1; i >= 0; i--) Console.Write ("{0}  ", a[i]);
         Console.WriteLine ("\n");
      }
   }
   #endregion 
}