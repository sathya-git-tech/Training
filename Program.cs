// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to calculate and display the average of four numbers entered by the user.
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>Find the average of four numbers</summary>
   internal class Program {
      #region Method ------------------------------------------------
      /// <summary>Getting input from the user</summary>
      /// <param name="args"></param>
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
         Console.WriteLine ("Average : " + (average));
      }
   }
   #endregion
}
#endregion