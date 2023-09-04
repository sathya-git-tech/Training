using System;
Console.Write ("Enter a number:");
int n = int.Parse (Console.ReadLine ());
Console.WriteLine ("Factorial for " + n + " is " + factorial (n));

static int factorial(int n) {
   int f = 1;
   for (int i = 1; i <= n; i++)
      f = f * i;
   return f;
}
