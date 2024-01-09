// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to ask the user for a single digit number and display
// The rectangle with 5 rows and 7 columns using that number. 
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>Display The rectangle with 5 rows , 7 columns using that number</summary>
   internal class Program {
      #region Method ------------------------------------------------
      /// <summary>Getting input from the user</summary>
      /// <param name="args">x</param>
      static void Main (string[] args) {
         Console.Write ("Enter a number : ");
         int x = Convert.ToInt32 (Console.ReadLine ());
         if (x <= 9) {
            Console.WriteLine ("{0}{0}{0}{0}{0}{0}{0}", x);
            for (int i = 0; i < 3; i++) Console.WriteLine ("{0}     {0}", x);
            Console.WriteLine ("{0}{0}{0}{0}{0}{0}{0}", x);
         } else Console.WriteLine ("Invalid input please enter a single digit number");
      }
   }
   #endregion 
}
#endregion 