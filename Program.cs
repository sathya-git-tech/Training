// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Expand the previous exercise (create 2d points), You need to create a menu like below. 
// Add (Add one point).Show (Show all the entered points).
// Average (Show the average values for x and y).Exit the program. 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>(Create 2d points), menu like Add, Show, Average, Exit the program</summary>
   internal class Program {
      #region Method ------------------------------------------------
      /// <summary>Getting input from the user</summary>
      static List<(double x, double y)> pointList = new ();
      static void Main (string[] args) {
         for (; ; ) {
            Console.WriteLine ("1. Add");
            Console.WriteLine ("2. Show");
            Console.WriteLine ("3. Average");
            Console.WriteLine ("4. Exit the Program");
            Console.Write ("\nEnter a choice : ");
            string choice = Console.ReadLine ();
            switch (choice) {
               case "1":
                  AddPoints ();
                  break;
               case "2":
                  ShowPoints ();
                  break;
               case "3":
                  Average ();
                  break;
               case "4":
                  Environment.Exit (0);
                  break;
               default:
                  Console.WriteLine ("Invalid choice . Please try again.");
                  break;
            }
         }
      }

      /// <summary>Add one point</summary>
      static void AddPoints () {
         Console.Write ("Enter a first point : ");
         double x1 = double.Parse (Console.ReadLine ());
         Console.Write ("Enter a second point : ");
         double y1 = double.Parse (Console.ReadLine ());
         pointList.Add ((x1, y1));
         Console.WriteLine ("Point added successfully!");
      }

      /// <summary>Show all the entered points</summary>
      static void ShowPoints () {
         Console.Write ("Entered points : ");
         foreach (var points in pointList) {
            Console.Write (points + " ");
         }
         Console.WriteLine ();
      }

      /// <summary>Show the average values for x and y</summary>
      static void Average () {
         if (pointList.Count > 0) {
            double averageX = pointList.Average (a => a.x);
            double averageY = pointList.Average (a => a.y);
            Console.WriteLine ($"Average X: {averageX}");
            Console.WriteLine ($"Average Y: {averageY}");
         } else Console.WriteLine ("No points entered.");
      }
      #endregion 
   }
   #endregion 
}