namespace Training {
   internal class Program {
      static void Main (string[] args) {
         string inputstr, reversestr = string.Empty;
         Console.Write ("Enter a string : ");
         inputstr = Console.ReadLine ();
           for (int i = inputstr.Length - 1; i >= 0; i--) {
                 reversestr += inputstr[i];
           }
           if (reversestr == inputstr) {
               Console.WriteLine ("String is Palindrome");
           } else {
               Console.WriteLine ("String is not Palindrome");
           }
      }
   }
}