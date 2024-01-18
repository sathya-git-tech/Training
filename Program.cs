// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a function called UpdateLetter(string text, int pos, char updateChar)
// That will update the character (updateChar) in the text at the given position.(pos).
// In main program ask the user to enter the text,character and position and call the
// UpdateLetter function to change the character and display the updated text. 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>UpdateLetter(string text, int pos, char updateChar)</summary>
   internal class Program {
      #region Method ------------------------------------------------
      /// <summary>Getting input from the user</summary>
      /// <param name="args">text,pos,updateChar</param>
      static void Main (string[] args) {
         Console.Write ("Enter the text : ");
         string text = Console.ReadLine ();
         Console.Write ("Enter the character position : ");
         int pos = int.Parse (Console.ReadLine ());
         Console.Write ("Enter the Updatecharacter : ");
         char updateChar = char.Parse (Console.ReadLine ());
         string updateText = UpdateLetter (text, pos, updateChar);
         Console.WriteLine ("Updated text : " + updateText);
      }

      /// <summary>UpdateLetter function to change the character and display the updated text</summary>
      /// <param name="text"></param>
      /// <param name="pos"></param>
      /// <param name="updateChar"></param>
      /// <returns>updatedText</returns>
      static string UpdateLetter (string text, int pos, char updateChar) {
         if (pos > 0 && pos < text.Length) {
            string removedChar = text.Remove (pos, 1);
            string updatedText = removedChar.Insert (pos, updateChar.ToString ());
            return updatedText;
         } else {
            Console.WriteLine ("Invalid position.");
            return text;
         }
      }
      #endregion
   }
   #endregion
}