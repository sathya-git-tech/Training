namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a password:");
         string password = Console.ReadLine ();


         bool Length = password.Length >= 6;
         bool Digit = password.Any (char.IsDigit);
         bool Lower = password.Any (char.IsLower);
         bool Upper = password.Any (char.IsUpper);
         bool Specialchar = password.Any (char.IsPunctuation);

         foreach (char i in password ) {  
               if (char.IsDigit (i)) {
                  Digit = true;
               }
               if (char.IsLower (i)) {
                  Lower = true;
               }
               if (char.IsUpper (i)) {
                  Upper = true;
               }
               if ("!@#$%^&*()-+".Contains (i)) {
                  Specialchar = true;
               }
         }
         bool var = Length && Digit && Lower && Upper && Specialchar;
         if (var == true) {
            Console.WriteLine ("password is strong");
         } else {
            Console.WriteLine ("password is not strong");
            if (Length == false) {
               Console.WriteLine ("password should be at least 6 character");
            }
            if (Digit == false) {
               Console.WriteLine ("password should contain at least one digit");
            }
            if(Lower == false) {
               Console.WriteLine ("password should contain at least one Lowercase English character");
            }
            if(Upper ==false) {
               Console.WriteLine ("password should contain at least one Uppercase English character");
            }
            if(Specialchar == false) {
               Console.WriteLine ("password should contain at least one Special character");
            }
         }
      }
   }
}