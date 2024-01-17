// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to ask the user for two numbers and display their division.
// Errors must be catches using "try..catch". 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Errors must be catches using "try..catch"</summary>
   internal class Program {
      static void Main (string[] args) {
         for (; ; ) {
            try {
               Console.Write ("Enter the first number: ");
               double num1 = double.Parse (Console.ReadLine ());
               Console.Write ("Enter the second number: ");
               double num2 = double.Parse (Console.ReadLine ());
               if (num2 != 0) {
                  double result = num1 / num2;
                  Console.WriteLine ($"{num1} / {num2} = {result}");
               }
               if (num2 == 0) throw new DivideByZeroException ();
            } catch (FormatException) {
               Console.Write ("Invalid input. Please enter a valid number\n");
            } catch (DivideByZeroException) {
               Console.Write ("Division by zero is not allowed. Please enter a non-zero value in the second number.\n");
            }
         }
      }
   }
   #endregion
}