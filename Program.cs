namespace Training {
   internal class Program {
      static void Main (string[] args) {
         Console.WriteLine ("Enter a name:");
         string name = Console.ReadLine ();
         Console.WriteLine ("Name is:" + name);
         for (int i = (name.Length - 1); i >=0; i--) {
            Console.WriteLine (name[i]);
         }
         Console.ReadKey ();
      }
   }
}