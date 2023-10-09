// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Chocolate wrappers
// Write a method, for a given money X along with price P of a chocolate and required wrappers W for a chocolate in exchange, return the maximum number of chocolates C you can get along with any unused money X and wrappers W. Use at least 1 keyword/technique: in, out, ref, optional parameters, multiple return values.
// For example, Sample Input:  1. (X=15,P=4,W=3), 2. (X=20,P=3,W=5) , Sample Output : 1. (C=4,X=3,W=1), 2. (C=7,X=2,W=2) .
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------

   /// <summary> Chocolate wrappers </summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary> Getting input from the user </summary>
      /// <param name="args"></param>

      static void Main (string[] args) {
         int x1, p1, w1;
         Console.Write ("Enter a initial money:");
         x1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a chocolate price:");
         p1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter wrappers needed for exchange:");
         w1 = int.Parse (Console.ReadLine ());
         var result = GetMaxChocolates (x1, p1, w1);
         Console.WriteLine ($"Result: (C = {result.C}, X = {result.X}, W = {result.W})");
      }
      /// <summary> Return the maximum number of chocolates, remaining price and wrappers </summary>
      /// <param name="money"> Amount user having intially </param>
      /// <param name="price"> Price of a chocolate </param>
      /// <param name="wrappers"> Number of wrappers can exchange the chocolate </param>
      /// <returns> Number of chocolates user can buy , remaining amount, number of wrappers left </returns>

      static (int C, int X, int W) GetMaxChocolates (int money, int price, int wrappers) {
         int chocolates = money / price;
         int wrappersLeft = chocolates;
         while (wrappersLeft >= wrappers) {
            int newChocolates = wrappersLeft / wrappers;
            chocolates += newChocolates;
            wrappersLeft = newChocolates + (wrappersLeft % wrappers);
         }
         int remainingMoney = money % price;
         return (chocolates, remainingMoney, wrappersLeft);
      }
      #endregion 
   }
   #endregion 
}