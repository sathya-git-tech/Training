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
         public double X;
         public double Y;
      }
      static void Main (string[] args) {
         Point p1, p2;
         Console.Write ("Enter X for first point : ");
         p1.X = double.Parse (Console.ReadLine ());
         Console.Write ("Enter Y for first point : ");
         p1.Y = double.Parse (Console.ReadLine ());
         Console.Write ("Enter X for second point : ");
         p2.X = double.Parse (Console.ReadLine ());
         Console.Write ("Enter Y for second point : ");
         p2.Y = double.Parse (Console.ReadLine ());
         Console.WriteLine ("P1 = ({0},{1})", p1.X, p1.Y);
         Console.WriteLine ("P2 = ({0},{1})", p2.X, p2.Y);
      }
   }
   #endregion 
}