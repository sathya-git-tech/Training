// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to get three numbers from the user and display the greatest one.
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Greatest among three</summary>
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number : ");
         int num1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number : ");
         int num2 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number : ");
         int num3 = int.Parse (Console.ReadLine ());
         if (num1 > num2) {
            if (num1 > num3)
               Console.Write ("The 1st Number is the greatest among three.\n");
            else
               Console.Write ("The 3rd Number is the greatest among three.\n");
         } else if (num2 > num3)
            Console.Write ("The 2nd Number is the greatest among three.\n");
         else
            Console.Write ("The 3rd Number is the greatest among three.\n");
      }
   }
   #endregion 
}
