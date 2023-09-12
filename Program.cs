namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a password:");
         string password = Console.ReadLine ();
         bool length = password.Length >= 6;
         bool upper = false; bool lower = false; bool digit = false; bool specialchar = false;
         for (int i = 0; i < password.Length; i++) {
            if (char.IsUpper (password[i])) upper = true;
            if (char.IsLower (password[i])) lower = true;
            if (char.IsDigit (password[i])) digit = true;
            if ("!@#$%^&*()-+".Contains (password[i])) specialchar = true;
         }
         Console.WriteLine (length && digit && upper && lower && specialchar == true ? "password is strong" : "password is not strong");
         if (!length) Console.WriteLine ("password should be at least 6 character");
         if (!digit) Console.WriteLine ("password should contain at least one digit");
         if (!lower) Console.WriteLine ("password should contain at least one Lowercase English character");
         if (!upper) Console.WriteLine ("password should contain at least one Uppercase English character");
         if (!specialchar) Console.WriteLine ("password should contain at least one Special character");
      }
   }
}