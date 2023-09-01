namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a password:");
         string password = Console.ReadLine ();


         bool length = password.Length >= 6;
         bool digit = password.Any (char.IsDigit);
         bool lower = password.Any (char.IsLower);
         bool upper = password.Any (char.IsUpper);
         bool specialchar = password.Any (c => "!@#$%^&*()-+".Contains (c));
         


         if ( length && digit && lower && upper && specialchar == true) {
            Console.WriteLine ("password is strong");
         } 
         else {
            Console.WriteLine ("password is not strong");
            if (password.Length < 6) {
               Console.WriteLine ("password should be at least 6 character");
            }
            if (!password.Any (char.IsDigit)) { 
               Console.WriteLine ("password should contain at least one digit");
            }
            if(!password.Any (char.IsLower)) { 
               Console.WriteLine ("password should contain at least one Lowercase English character");
            }
            if(!password.Any (char.IsUpper)) {
               Console.WriteLine ("password should contain at least one Uppercase English character");
            }
            if (!password.Any (c => "!@#$%^&*()-+".Contains (c))) {
               Console.WriteLine ("password should contain at least one Special character");
            }
         }
      }
   }
}