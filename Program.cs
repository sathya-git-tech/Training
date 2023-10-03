namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter a string: ");
         string input = Console.ReadLine ().ToUpper ();
         int n = input.Length;
         permute (input, 0, n - 1);
      }
      static void permute (string input, int l, int r) {
         if (l == r)
            Console.WriteLine (input);
         else {
            for (int i = l; i <= r; i++) {
               input = swap (input, l, i);
               permute (input, l + 1, r);
               input = swap (input, l, i);
            }
         }
      }
      static string swap (string a, int i, int j) {
         char temp;
         char[] charArray = a.ToCharArray ();
         temp = charArray[i];
         charArray[i] = charArray[j];
         charArray[j] = temp;
         string s = new (charArray);
         return s;
      }
   }
}