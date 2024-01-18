// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Create a "struct" to store data of 2D points. The fields for each point will be:
// double X double Y Write a C# program which creates two "points",
// asks the user for their data, and then displays their content. 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Create a "struct" to store data of 2D points</summary>
   internal class Program {
      struct Point {
         public double x;
         public double y;
      }
      static void Main (string[] args) {
         Point p1, p2;
         Console.Write ("Enter X for first point : ");
         p1.x = double.Parse (Console.ReadLine ());
         Console.Write ("Enter Y for first point : ");
         p1.y = double.Parse (Console.ReadLine ());
         Console.Write ("Enter X for second point : ");
         p2.x = double.Parse (Console.ReadLine ());
         Console.Write ("Enter Y for second point : ");
         p2.y = double.Parse (Console.ReadLine ());
         Console.WriteLine ("P1 = ({0},{1})", p1.x, p1.y);
         Console.WriteLine ("P2 = ({0},{1})", p2.x, p2.y);
      }
   }
   #endregion 
}