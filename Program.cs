using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;

namespace P1 {
   internal class Program {
      static void Main (string[] args) {
         string[] colour = { "red", "green", "blue" };
         var input = File.ReadAllLines ("C:\\etc\\input.txt").Where (s => s.Contains ("Game 1:"));
         Dictionary<int, string> keyValuePairs = new Dictionary<int, string> ();
         if (keyValuePairs.Count > 12) {
            Console.WriteLine ("The game not possible");
         } else Console.WriteLine ($"Possible");
         if (keyValuePairs.Count > 13) {
            Console.WriteLine ("The game not possible");
         } else Console.WriteLine ($"Possible");
         if (keyValuePairs.Count > 14) {
            Console.WriteLine ("The game not possible");
         } else Console.WriteLine ($"Possible");
         foreach (var line in input) {
            Console.WriteLine (line);
         }
      }
   }
}