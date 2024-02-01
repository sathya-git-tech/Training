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

         public Date (int day, int month, int year) {
            Day = day;
            Month = month;
            Year = year;
         }
      }

      public struct Person {
         public string Name;
         public Date Birthday;

         public Person (string name, Date birthday) {
            Name = name;
            Birthday = birthday;
         }
      }

      static void Main (string[] args) {
         Person[] people = new Person[2];
         for (int i = 0; i < 2; i++) {
            Console.Write ("Enter a name (with initial) : ");
            string name = Console.ReadLine ();
            Console.Write ("Enter a Birthday Day : ");
            int day = int.Parse (Console.ReadLine ());
            Console.Write ("Enter a Birthday Month : ");
            int month = int.Parse (Console.ReadLine ());
            Console.Write ("Enter a Birthday Year : ");
            int year = int.Parse (Console.ReadLine ());
            people[i] = new Person (name, new Date (day, month, year));
         }
         foreach (Person p in people) {
            Console.WriteLine ($"{p.Name} : {p.Birthday.Day}-{p.Birthday.Month}-{p.Birthday.Year}");
         }
      }
   }
   #endregion
}