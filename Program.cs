// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Sort and swap special Characters
// Given a character array A, along with special character S and sort order O (default order is Ascending), print the sorted array by keeping the elements matching S to the last of the array. 
// For example, Sample Input: 1. ([a, b, c, a, c, b, d], a, “descending”), 2. ([z, y, x], a)  Sample Output: 1. “d, c, c, b, b, a, a”, 2. “x, y, z” .
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary> Sort and swap special characters </summary>
   internal class Program {
      #region Methods ------------------------------------------------------------------------------
      /// <summary> Getting input from the user </summary>
      /// <param name="args"></param>
      static void Main (string[] args) {
         Console.Write ("Enter characters: ");
         string input = Console.ReadLine ()!;
         Console.Write ("Enter the special character: ");
         char specialChar = char.Parse (Console.ReadLine ()!);
         Console.Write ("Enter D or d for descending order, otherwise press Enter key: ");
         char sortOrderKey = Console.ReadKey ().KeyChar;
         List<char> charList = new (input);
         string result = SwapSpecialCharacters (charList, sortOrderKey, specialChar);
         Console.WriteLine ("\nResult: " + result);
      }
      /// <summary> Sort the characters based on the sortOrderKey </summary>
      /// <param name="input"> Character enter by the user </param>
      /// <param name="sortOrderKey"> Sort based on the key given by the user </param>
      /// <param name="specialChar"> Special character </param>
      /// <returns> Sort and swap special characters </returns>
      static string SwapSpecialCharacters (List<char> input, char sortOrderKey, char specialChar) {
         int count = input.Count (x => x == specialChar);
         input.RemoveAll (c => c == specialChar);
         input.Sort ();
         if (sortOrderKey is 'D' or 'd') input.Reverse ();
         for (int i = 0; i < count; i++) input.Add (specialChar);
         return new string (input.ToArray ());
      }
      #endregion 
   }
   #endregion 
}