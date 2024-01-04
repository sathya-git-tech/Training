namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter your name:");
         string name = Console.ReadLine ();
         Console.WriteLine ("Enter your age:");
         int age = int.Parse (Console.ReadLine ());
         Console.WriteLine ("Enter your address:");
         string address = Console.ReadLine ();
         Console.WriteLine ($"Name:{name}, Age:{age}, Address:{address}");
      }
   }
}