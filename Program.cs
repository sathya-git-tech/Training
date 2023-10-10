// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// VOTING CONTEST 
// Given a string S to a method, with each character in it representing a vote for a contestant, return the winner with the most votes. If 2 or more contestants have the same number of votes, the contestant who got the first vote among them is declared a winner. 
// For example, Sample Input:  AabBBcd,Helloworld ;Sample Output (Any of these): B or b  L, 3 => Winner and votes  
// --------------------------------------------------------------------------------------------
namespace Training {
   #region  Program ------------------------------------------------------------------------------
   /// <summary>VOTING CONTEST</summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary>getting input from the user </summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
         Console.WriteLine ("Enter a word: ");
         string input = Console.ReadLine ();
         Console.WriteLine (FindWinner (input));
      }
      /// <summary> Finding the winner based on the vote </summary>
      /// <param name="input">Word</param>
      static (char, int) FindWinner (string input) {
         char previousChar = input[0];
         int currentCount = 1;
         char winnerChar = previousChar;
         int winnerCount = currentCount;
         for (int i = 1; i < input.Length; i++) {
            char inputchar = input[i];
            if (input[i] == previousChar && previousChar != winnerChar) {
               currentCount++;
               previousChar = inputchar;
            } else {
               if (currentCount > winnerCount) {
                  winnerChar = previousChar;
                  winnerCount = currentCount;
               }
               if (input[i] == winnerChar) {
                  winnerCount++;
                  winnerChar = inputchar;
               }
               previousChar = inputchar;
               currentCount = 1;
            }
         }
         return (winnerChar, winnerCount);
      }
      #endregion
   }
   #endregion
}