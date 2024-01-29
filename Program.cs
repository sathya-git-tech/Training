// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Write a program to create a student directory in D drive and ask the user to
// Enter student name. Create the file with that name and store in student folder
// Then ask the user to enter the  student details name, age, city, and subject.
// You must save the student information with dates in that file.
// You need to create a menu like below,View File
// (Print the student’s name, age, city, subject, and date).
// View Directory (Print the full path of the file). 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>Create a student directory ask the user to (name,age,city,subject)</summary>
   internal class Program {
      #region Methods -----------------------------------------------
      /// <summary>Getting input from the user</summary>
      static void Main (string[] args) {
         string directoryPath = @"W:\Training\Student";
         for (; ; ) {
            Console.WriteLine ("1. Add student details ");
            Console.WriteLine ("2. View File (Print student details)");
            Console.WriteLine ("3. View directory (Print directory path)");
            Console.WriteLine ("4. Exit");
            Console.Write ("Enter your choice : ");
            string choice = Console.ReadLine ();
            switch (choice) {
               case "1":
                  AddStudentDetails (directoryPath);
                  break;
               case "2":
                  ViewFile (directoryPath);
                  break;
               case "3":
                  Console.WriteLine ($"Directory Path : {directoryPath}\n");
                  break;
               case "4":
                  Environment.Exit (0);
                  break;
               default:
                  Console.WriteLine ("Invalid choice");
                  break;
            }
         }
      }

      /// <summary>Add the student details</summary>
      static void AddStudentDetails (string directoryPath) {
         Console.Write ("Enter student name : ");
         string studentName = Console.ReadLine ();
         string filePath = Path.Combine (directoryPath, $"{studentName}.txt");
         Console.Write ("Enter student age : ");
         int age = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a city : ");
         string city = Console.ReadLine ();
         Console.Write ("Enter a subject : ");
         string subject = Console.ReadLine ();
         using var writer = new StreamWriter (filePath);
         writer.WriteLine ($"Name : {studentName}");
         writer.WriteLine ($"Age : {age}");
         writer.WriteLine ($"City : {city}");
         writer.WriteLine ($"Subject : {subject}");
         writer.WriteLine ($"Date : {DateTime.Now}");
         Console.WriteLine ("Student details added successfully\n");
      }

      /// <summary>View file print the student’s name, age, city, subject, and date</summary>
      static void ViewFile (string directoryPath) {
         Console.Write ("Enter student name to view details : ");
         string studentName = Console.ReadLine ();
         string filePath = Path.Combine (directoryPath, $"{studentName}.txt");
         if (File.Exists (filePath)) Console.WriteLine (File.ReadAllText (filePath));
         else Console.WriteLine ("Student file not found");
      }
      #endregion
   }
   #endregion
}