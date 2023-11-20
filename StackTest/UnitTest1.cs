using Training;
namespace StackTest {
   [TestClass]
   public class UnitTest1 {
      Tstack<int> myStack = new ();
      Stack<int> stack = new ();

      [TestMethod]
      public void TestPeek () {
         for (int i = 1; i <= 5; i++) {
            myStack.Push (i);
            stack.Push (i);
         }
         Assert.AreEqual (stack.Peek (), myStack.Peek ());
         for (int i = 1; i <= 5; i++) Assert.AreEqual (myStack.Pop (), stack.Pop ());
         Assert.ThrowsException<InvalidOperationException> (() => myStack.Peek ());
         Assert.ThrowsException<InvalidOperationException> (() => stack.Peek ());
         Assert.IsTrue (myStack.IsEmpty);
      }

      [TestMethod]
      public void TestPop () {
         for (int i = 1; i <= 5; i++) {
            myStack.Push (i);
            stack.Push (i);
         }
         Assert.AreEqual (stack.Count, myStack.Count);
         for (int i = 1; i <= 5; i++) {
            myStack.Pop ();
            stack.Pop ();
         }
         Assert.IsTrue (myStack.IsEmpty);
         Assert.ThrowsException<InvalidOperationException> (() => myStack.Pop ());
         Assert.ThrowsException<InvalidOperationException> (() => stack.Pop ());
      }

      [TestMethod]
      public void TestPush () {
         for (int i = 1; i <= 5; i++) {
            myStack.Push (i);
            stack.Push (i);
         }
         Assert.AreEqual (myStack.Count, stack.Count);
         Assert.AreEqual (8, myStack.Capacity);
      }
   }
}