namespace Training {
   internal class Program {
      static void Main (string[] args) {
            Console.WriteLine ("Enter your name:");
            string name = Console.ReadLine ();
            Console.WriteLine ("Enter your age:");
            int age = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Enter your address:");
            string address = Console.ReadLine ();
         

         
            int a = -5 + 7 * 2;
            Console.WriteLine ($"a={a}");
            int b = (53 + 2) % 3;
            Console.WriteLine ($"b={b}");
            int c = 46 + -4 * 6 / 11;
            Console.WriteLine ($"c={c}");
            int d = 5 + 40 / 2 * 1 - 5 % 2;
            Console.WriteLine ($"d={d}");
         


         Console.Write ("Enter a number1:");
         int num1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number2:");
         int num2 = int.Parse (Console.ReadLine ());
         int addition = num1 + num2;
         Console.WriteLine ($"addition:{addition}");
         int subraction = num1 - num2;
         Console.WriteLine ($"subraction: {subraction}");
         int multiplication = num1 * num2;
         Console.WriteLine ($"multiplication: {multiplication}");
         int division = num1 / num2;
         Console.WriteLine ($"division: {division}");
         int modulodivision = num1 % num2;
         Console.WriteLine ($"modulodivision:{modulodivision}");


         Console.Write ("Enter a number1:");
         int n1 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number1:");
         int n2 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number1:");
         int n3 = int.Parse (Console.ReadLine ());
         Console.Write ("Enter a number1:");
         int n4 = int.Parse (Console.ReadLine ());
         int average = (n1 + n2 + n3 + n4) / 4;
         Console.WriteLine ($"The Average of four number is :{average}");


         Console.Write ("Enter a number:");
         int n = int.Parse (Console.ReadLine ());
         for (int i = 1; i <= 20; i++) {
            Console.WriteLine ($"{i,2}" + " *  " + n + " = " + (i * n));
         }
      }
   }
}