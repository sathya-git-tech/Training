// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to ask the user for enter two persons
// Name and date of birth and display them in console.For that,
// You must create the struct for a Person, the fields for Person will be: 
// string Name Date Birthday Date is a another struct, the fields for Date is: int Day 
// int Month int Year. 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Create the struct for a person, the fields for Name and Birthday Date</summary>
   internal class Program {
      public struct Date {
         public int Day;
         public int Month;
         public int Year;
      }

      public struct Person {
         public string Name;
         public Date Birthday;
      }

      static void Main (string[] args) {
         for (; ; ) {
            Person p1, p2;
            Console.Write ("Enter a name (with intial) : ");
            p1.Name = Console.ReadLine ();
            Console.Write ("Enter a Birythday Day : ");
            p1.Birthday.Day = int.Parse (Console.ReadLine ());
            Console.Write ("Enter a Birthday Month : ");
            p1.Birthday.Month = int.Parse (Console.ReadLine ());
            Console.Write ("Enter a Birthday Year : ");
            p1.Birthday.Year = int.Parse (Console.ReadLine ());
            Console.Write ("Enter a name : ");
            p2.Name = Console.ReadLine ();
            Console.Write ("Enter a Birythday Day : ");
            p2.Birthday.Day = int.Parse (Console.ReadLine ());
            Console.Write ("Enter a Birthday Month : ");
            p2.Birthday.Month = int.Parse (Console.ReadLine ());
            Console.Write ("Enter a Birthday Year : ");
            p2.Birthday.Year = int.Parse (Console.ReadLine ());
            Console.Write ($"{p1.Name} : {p1.Birthday.Day}-{p1.Birthday.Month}-{p1.Birthday.Year}\n");
            Console.Write ($"{p2.Name} : {p2.Birthday.Day}-{p2.Birthday.Month}-{p2.Birthday.Year}\n");
         }
      }
   }
   #endregion
}