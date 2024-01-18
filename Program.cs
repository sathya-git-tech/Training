namespace Training {
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
         Person p1, p2;
         Console.Write ("Enter a name (with intial) : ");
         p1.Name = Console.ReadLine ();
         Console.Write ("Enter a Birythday day : ");
         p1.Birthday.Day = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a Birthday Month : ");
         p1.Birthday.Month = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a Birthday year : ");
         p1.Birthday.Year = int.Parse (Console.ReadLine ());
         Console.Write ($"\nName : {p1.Name}\nBirthday day : {p1.Birthday.Day}\nBirthday Month : {p1.Birthday.Month}\nBirthday year : {p1.Birthday.Year}\n");
         Console.WriteLine ();
         Console.Write ("Enter a name : ");
         p2.Name = Console.ReadLine ();
         Console.Write ("Enter a Birythday day : ");
         p2.Birthday.Day = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a Birthday Month : ");
         p2.Birthday.Month = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a Birthday year : ");
         p2.Birthday.Year = int.Parse (Console.ReadLine ());
         Console.Write ($"\nName : {p2.Name}\nBirthday day : {p2.Birthday.Day}\nBirthday Month : {p2.Birthday.Month}\nBirthday year : {p2.Birthday.Year}");
         Console.WriteLine ();
      }
   }
}