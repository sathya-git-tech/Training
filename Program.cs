namespace Training {
   internal class Program {
      static void Main (string[] args) {
         // Convert numbers to words

         Console.WriteLine ("Enter a number:");
         int number = int.Parse (Console.ReadLine ());
         int num = number;

         string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
         string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

         string words = string.Empty;
         if (number < 0 || number > 999) {
            Console.WriteLine ("Number out of range for words conversion");
         }



         if (number == 0) {
            Console.WriteLine ("Zero");
         }

         if (number >= 100) {
            words += units[number / 100] + " Hundred";
            number %= 100;
            if (number > 0) {
               words += " and ";
            }

         }

         if (number >= 20) {
            words += tens[number / 10];
            number %= 10;
            if (number > 0) {
               words += " ";
            }
         }

         

         if (number > 0) {
            words += units[number];
         }
         Console.WriteLine ($"{words}");


         // Convert Integer to roman


         
         string romanResult = string.Empty;
         string[] roman = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
         int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

         int i = 0;
         while (num != 0) {
            if (num >= numbers[i]) {
               num -= numbers[i];
               romanResult += roman[i];
               Console.Write($"{roman[i]}");
            } else {
               i++;
            }
         }
      }
   }
}