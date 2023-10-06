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
         string input = Console.ReadLine ().ToLower ();
         if (string.IsNullOrEmpty (input)) {
            Console.WriteLine ("Input is empty.");
            return;
         }
         // Call the method to find the winner
         Console.WriteLine (FindWinner (input));
      }
      /// <summary> Finding the winner based on the vote </summary>
      /// <param name="input">Word</param>
      static (char, int) FindWinner (string input) {
         // Assuming these variables are declared before the loop
         char currentChar = input[0];
         int currentCount = 1;
         char winnerChar = currentChar;
         int winnerCount = currentCount;

         for (int i = 1; i < input.Length; i++) {
            if (char.IsLetter (input[i]) && input[i] == currentChar) {
               currentCount++;
               currentChar = input[i];
            } else {
               if (currentCount > winnerCount) {
                  winnerChar = char.ToUpper (currentChar);
                  winnerCount = currentCount;
               }
               if (char.IsLetter (input[i])) {
                  currentChar = input[i];
                  currentCount = 1;
               }
            }
         }

         // Check for the last character sequence
         if (currentCount > winnerCount) {
            winnerChar = char.ToUpper (currentChar);
            winnerCount = currentCount;
         }
         return (winnerChar, winnerCount);
      }
      #endregion
   }
   #endregion
}