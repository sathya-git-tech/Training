using Training;
namespace StackTest {
   [TestClass]
   public class UnitTest1 {
      Tstack<int> myStack = new ();
      Stack<int> stack = new ();
      [TestMethod]
      public void TestPush () {
         for (int i = 1; i <= 5; i++) {
            myStack.Push (i);
            stack.Push (i);
         }
         Assert.AreEqual (myStack.Count, stack.Count);
         myStack.Push (10);
         Assert.AreEqual (8, myStack.Capacity);
      }

      [TestMethod]
      public void TestPop () {
         for (int i = 1; i <= 5; i++) {
            myStack.Push (i);
            stack.Push (i);
         }
         for (int i = 1; i <= 5; i++) {
            myStack.Pop ();
            stack.Pop ();
         }
         Assert.AreEqual (stack.Count, myStack.Count);
         Assert.ThrowsException<InvalidOperationException> (() => myStack.Pop ());
         Assert.IsTrue (myStack.IsEmpty);
      }

      [TestMethod]
      public void TestPeek () {
         for (int i = 1; i <= 5; i++) {
            myStack.Push (i);
            stack.Push (i);
         }
         myStack.Peek ();
         stack.Peek ();
         Assert.AreEqual (8, myStack.Capacity);
         Assert.AreEqual (5, myStack.Peek ());
         Assert.AreEqual (myStack.Pop (), stack.Pop ());
         Assert.AreEqual (myStack.Pop (), stack.Pop ());
         Assert.AreEqual (myStack.Pop (), stack.Pop ());
         Assert.AreEqual (myStack.Pop (), stack.Pop ());
         Assert.AreEqual (myStack.Pop (), stack.Pop ());
         Assert.ThrowsException<InvalidOperationException> (() => myStack.Peek ());
         Assert.IsTrue (myStack.IsEmpty);
      }

   }

}