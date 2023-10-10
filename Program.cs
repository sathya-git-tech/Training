// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Voting contest  
// Given a string S to a method, with each character in it representing a vote for a contestant, return the winner with the most votes. If 2 or more contestants have the same number of votes, the contestant who got the first vote among them is declared a winner. 
// For example, Sample Input:  AabBBcd,Helloworld ;Sample Output (Any of these): B or b  L, 3 => Winner and votes  
// --------------------------------------------------------------------------------------------
namespace Training {
   #region  Program ------------------------------------------------------------------------------
   /// <summary> Votting contest </summary>
   internal class Program {
      #region Methods ---------------------------------------------
      /// <summary> Getting input from the user </summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
         Console.WriteLine ("Enter a word: ");
         string input = Console.ReadLine ()!;
         Console.WriteLine (FindWinner (input));
      }
      /// <summary> Finding the winner based on the vote </summary>
      /// <param name="input">Word</param>
      /// <returns> Maximum character and maximum count </returns>
      static (char, int) FindWinner (string input) {
         char maxChar = ' ';
         int maxCount = 0;
         for (int i = 0; i < input.Length; i++) {
            char currentChar = input[i];
            int currentCount = 1;
            // Count occurrences of the current character in the rest of the string
            for (int j = i + 1; j < input.Length; j++) {
               if (input[j] == currentChar) {
                  currentCount++;
               }
            }
            // Update maxChar and maxCount if a higher count is found
            if (currentCount > maxCount) {
               maxChar = currentChar;
               maxCount = currentCount;
            }
         }
         return (maxChar, maxCount);
      }
      #endregion
   }
   #endregion
}
