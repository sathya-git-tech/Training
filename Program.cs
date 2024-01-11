// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program which asks the user for two numbers and an
// Operation to perform on them (+,-,*,x,/) and displays the
// Result of that operation, as in this example: Enter first number: 5 Enter operation: +
// Enter second number: 7 5 + 7 = 12Note: you MUST use "switch", not "if"
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Operation (+,-,*,x,/)</summary>
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a first number : ");
         int num1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter operation : ");
         string operation = Console.ReadLine ();
         Console.Write ("Enter a second number : ");
         int num2 = int.Parse (Console.ReadLine ());
         switch (operation) {
            case "+":
               Console.WriteLine ($"{num1} + {num2} = " + (num1 + num2));
               break;
            case "-":
               Console.WriteLine ($"{num1} - {num2} = " + (num1 - num2));
               break;
            case "*":
               Console.WriteLine ($"{num1} * {num2} = " + (num1 * num2));
               break;
            case "/":
               Console.WriteLine ($"{num1} / {num2} = " + (num1 / num2));
               break;
            case "%":
               Console.WriteLine ($"{num1} % {num2} = " + (num1 % num2));
               break;
            default:
               Console.WriteLine ("Invalid operation");
               break;
         }
      }
   }
   #endregion 
}