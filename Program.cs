namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a number: ");
         string number = Console.ReadLine ();
         if (double.TryParse (number, out _)) {
            string[] parts = number.Split ('.');
            string integralPart = parts[0];
            string fractionalPart = parts.Length > 1 ? parts[1] : "";
            Console.Write ("Integral part: ");
            foreach (char digit in integralPart) Console.Write ($"{digit} ");
            Console.WriteLine ();
            if (!string.IsNullOrEmpty (fractionalPart)) Console.Write ("Fractional part: ");
            foreach (char digit in fractionalPart) Console.Write ($"{digit} ");
            Console.WriteLine ();
         } 
         else Console.WriteLine ("Invalid input. Please enter a valid number.");
      }
   }
}
