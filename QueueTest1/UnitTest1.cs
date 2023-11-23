using Training;
namespace QueueTest {
   [TestClass]
   public class UnitTest1 {
      TQueue<int> myQueue = new ();
      Queue<int> Queue = new ();

      [TestMethod]
      public void TestDequeue () {
         for (int i = 1; i <= 4; i++) {
            myQueue.Enqueue (i);
            Queue.Enqueue (i);
         }
         Assert.AreEqual (myQueue.Count, Queue.Count);
         for (int i = 1; i <= 4; i++) {
            myQueue.Dequeue ();
            Queue.Dequeue ();
         }
         Assert.IsTrue (myQueue.IsEmpty);
         Assert.ThrowsException<InvalidOperationException> (() => myQueue.Dequeue ());
         Assert.ThrowsException<InvalidOperationException> (() => Queue.Dequeue ());
      }

      [TestMethod]
      public void TestEnqueue () {
         for (int i = 1; i <= 4; i++) {
            myQueue.Enqueue (i);
            Queue.Enqueue (i);
         }
         Assert.AreEqual (myQueue.Count, Queue.Count);
      }

      [TestMethod]
      public void TestPeek () {
         Assert.ThrowsException<InvalidOperationException> (() => myQueue.Peek ());
         Assert.ThrowsException<InvalidOperationException> (() => Queue.Peek ());
         Assert.IsTrue (myQueue.IsEmpty);
         for (int i = 1; i <= 2; i++) {
            myQueue.Enqueue (i);
            Queue.Enqueue (i);
         }
         Assert.AreEqual (Queue.Peek (), myQueue.Peek ());
      }
   }
}