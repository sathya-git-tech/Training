// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Create a program which will allow the user to: Add (Add a number in list).
// Show (Show all the entered numbers). Find (Ask the user to enter the number,
// And you must show the given number is already added or not with index number).
// View (Total numbers, Sum, Average, Maximum, Minimum) , Exit the program. 
// You must create a menu and each option will be chosen by a number. 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Add, Show, Find, View, Exit</summary>
   internal class Program {
      static List<int> list = new ();
      #region Method ------------------------------------------------
      /// <summary>Choose an option</summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
         for (; ; ) {
            Console.WriteLine ("Choose an option : ");
            Console.WriteLine ("1. Add");
            Console.WriteLine ("2. Show");
            Console.WriteLine ("3. Find");
            Console.WriteLine ("4. View");
            Console.WriteLine ("5. Exit");
            string choice = Console.ReadLine ();
            switch (choice) {
               case "1":
                  AddNumber ();
                  break;
               case "2":
                  ShowNumbers ();
                  break;
               case "3":
                  FindNumbers ();
                  break;
               case "4":
                  ViewNumbers ();
                  break;
               case "5":
                  Environment.Exit (0);
                  break;
               default:
                  Console.WriteLine ("Invalid choice. Please try again");
                  break;
            }
         }
      }

      /// <summary>Add a number in list</summary>
      static void AddNumber () {
         Console.Write ("Enter a number to add : ");
         if (int.TryParse (Console.ReadLine (), out int number)) {
            list.Add (number);
            Console.WriteLine ("Number added successfully!");
         } else Console.WriteLine ("Invalid input. Please enter a valid number");
      }

      /// <summary>Show all the entered numbers</summary>
      static void ShowNumbers () {
         Console.Write ("Entered numbers : ");
         foreach (var number in list) {
            Console.Write (number + " ");
         }
         Console.WriteLine ();
      }

      /// <summary>Find the given number is already added or not with index number</summary>
      static void FindNumbers () {
         Console.Write ("Enter a number to find : ");
         if (int.TryParse (Console.ReadLine (), out int number)) {
            int index = list.IndexOf (number);
            if (index != -1) Console.WriteLine ($"Number {number} found at index of {index}.");
            else Console.WriteLine ($"Number {number} not found.");
         }
      }

      /// <summary>Total numbers, Sum, Average, Maximum, Minimum</summary>
      static void ViewNumbers () {
         Console.Write ($"Total numbers : {list.Count}");
         if (list.Count > 0) {
            Console.WriteLine ($"\nSum : {list.Sum ()}");
            Console.WriteLine ($"Average : {list.Average ()}");
            Console.WriteLine ($"Maximum : {list.Max ()}");
            Console.WriteLine ($"Minimum : {list.Min ()}");
         }
      }
      #endregion
   }
   #endregion
}