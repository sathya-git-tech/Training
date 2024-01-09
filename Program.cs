// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to ask the user for his/her login and his/her
// Password and validate the entered input.
// Login is "Learn" and the password is "74123". The user will have 3 attempts maximum. 
// ---------------------------------------------------------------------------------------
namespace Training {
   #region Program -----------------------------------------------------------------------
   /// <summary>Login user id and password</summary>
   internal class Program {
      #region Method ------------------------------------------------
      /// <summary>Getting input from the user</summary>
      /// <param name="args">x,y</param>
      static void Main (string[] args) {
         string login = "Learn";
         string password = "74123";
         for (int i = 1; i <= 3; i++) {
            Console.Write ("Enter a login Id : ");
            string x = Console.ReadLine ();
            Console.Write ("Enter a password : ");
            string y = Console.ReadLine ();
            if (login == x && password == y) {
               Console.WriteLine ($"You have succesfully Login in {i} attempts.");
               break;
            } else {
               Console.WriteLine ($"The login Id and password is invalid. Remaining {3 - i} attempts");
               Console.WriteLine (i < 3 ? "Try again." : "Maximum attempts reached. Exiting program.");
            }
         }
      }
   }
   #endregion
}
#endregion