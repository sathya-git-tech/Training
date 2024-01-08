// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a C# program to print the addition, subtraction, multiplication, division,
// modulo division of two numbers which will entered by the user. 
// ---------------------------------------------------------------------------------------
namespace Training {
   #region class Program -----------------------------------------------------------------
   /// <summary>Print the Console applications</summary>
   internal class Program {
      #region Method ------------------------------------------------
      /// <summary>Getting input from the user</summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
         Console.Write ("Enter a number1 : ");
         int num1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number2 : ");
         int num2 = int.Parse (Console.ReadLine ());
         Console.WriteLine ("Addition : " + (num1 + num2));
         Console.WriteLine ("Subraction : " + (num1 - num2));
         Console.WriteLine ("Multiplication : " + num1 * num2);
         Console.WriteLine ("Division : " + num1 / num2);
         Console.WriteLine ("Modulodivision : " + num1 % num2);
      }
   }
   #endregion 
}
#endregion