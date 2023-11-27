using Training;
namespace TestQueue {
   [TestClass]
   public class UnitTest1 {
      TQueue<int> myQueue = new ();
      Queue<int> Queue = new ();

      [TestMethod]
      public void TestDequeue () {
         for (int i = 1; i <= 5; i++) {
            myQueue.Enqueue (i);
            Queue.Enqueue (i);
         }
         for (int i = 1; i <= 3; i++) {
            myQueue.Dequeue ();
            Queue.Dequeue ();
         }
         Assert.AreEqual (2, myQueue.Count);
         for (int i = 6; i <= 8; i++) {
            myQueue.Enqueue (i);
            Queue.Enqueue (i);
         }
         for (int i = 1; i <= 5; i++) {
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
         Assert.AreEqual (4, myQueue.Capacity);
      }

      [TestMethod]
      public void TestPeek () {
         for (int i = 1; i <= 5; i++) {
            myQueue.Enqueue (i);
            Queue.Enqueue (i);
         }
         Assert.AreEqual (Queue.Peek (), myQueue.Peek ());
         for (int i = 1; i <= 3; i++) {
            myQueue.Dequeue ();
            Queue.Dequeue ();
         }
         Assert.AreEqual (Queue.Peek (), myQueue.Peek ());
         for (int i = 1; i <= 2; i++) {
            myQueue.Dequeue ();
            Queue.Dequeue ();
         }
         Assert.IsTrue (myQueue.IsEmpty);
         Assert.ThrowsException<InvalidOperationException> (() => Queue.Peek ());
         Assert.ThrowsException<InvalidOperationException> (() => myQueue.Peek ());

      }
   }
}