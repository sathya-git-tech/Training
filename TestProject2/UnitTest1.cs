using Training;
namespace ListTest {
   [TestClass]
   public class UnitTest1 {
      MyList<int> myList = new ();
      List<int> list = new ();

      [TestMethod]
      public void TestAdd () {
         for (int i = 10; i <= 40; i += 10) {
            myList.Add (i);
            list.Add (i);
         }
         Assert.AreEqual (list[0], myList[0]);
         Assert.AreEqual (myList.Count, list.Count);
         Assert.AreEqual (myList.Capacity, list.Capacity);
         Assert.ThrowsException<IndexOutOfRangeException> (() => myList[-3]);
         Assert.ThrowsException<IndexOutOfRangeException> (() => myList[-6]);
      }

      [TestMethod]
      public void TestClear () {
         for (int i = 10; i <= 40; i += 10) {
            myList.Add (i);
            list.Add (i);
         }
         myList.Clear ();
         list.Clear ();
         Assert.AreEqual (myList.Count, list.Count);
      }

      [TestMethod]
      public void TestInsert () {
         for (int i = 10; i <= 40; i += 10) {
            myList.Add (i);
            list.Add (i);
         }
         Assert.AreEqual (myList.Count, list.Count);
         myList.Insert (2, 12);
         list.Insert (2, 12);
         myList[3] = 5;
         Assert.AreEqual (list.Count, myList.Count);
         Assert.AreEqual (list.Capacity, myList.Capacity);
         Assert.ThrowsException<IndexOutOfRangeException> (() => myList.Insert (10, 12));
      }

      [TestMethod]
      public void TestRemove () {
         for (int i = 10; i <= 40; i += 10) {
            myList.Add (i);
            list.Add (i);
         }
         myList.Remove (10);
         list.Remove (10);
         Assert.AreEqual (list.Count, myList.Count);
      }

      [TestMethod]
      public void TestRemoveAt () {
         for (int i = 10; i <= 40; i += 10) {
            myList.Add (i);
            list.Add (i);
         }
         myList.RemoveAt (2);
         list.RemoveAt (2);
         Assert.AreEqual (myList.Count, list.Count);
         Assert.ThrowsException<ArgumentOutOfRangeException> (() => myList.RemoveAt (6));
      }
   }
}