using Training;
namespace ListTest {
   [TestClass]
   public class UnitTest1 {
      MyList<int> myList = new ();
      List<int> list = new ();
      [TestMethod]
      public void TestAdd () {
         myList.Add (10);
         myList.Add (20);
         myList.Add (30);
         myList.Add (40);
         list.Add (10);
         list.Add (20);
         list.Add (30);
         list.Add (40);
         Assert.AreEqual (list[0], myList[0]);
         Assert.AreEqual (myList.Count, list.Count);
         Assert.AreEqual (myList.Capacity, list.Capacity);
         Assert.AreEqual (4, myList.Count);
         myList.Add (50);
         Assert.AreEqual (8, myList.Capacity);
         myList[2] = 5;
         Assert.AreEqual (5, myList[2]);
         Assert.ThrowsException<IndexOutOfRangeException> (() => myList[-3] = 5);
         Assert.ThrowsException<IndexOutOfRangeException> (() => myList[-6]);
         myList.Add (50);
         Assert.AreEqual (8, myList.Capacity);
      }
      [TestMethod]
      public void TestClear () {
         myList.Add (10);
         myList.Add (20);
         myList.Add (30);
         myList.Add (40);
         myList.Clear ();
         list.Add (10);
         list.Add (20);
         list.Add (30);
         list.Add (40);
         list.Clear ();
         Assert.AreEqual (myList.Count, list.Count);
      }
      [TestMethod]
      public void TestInsert () {
         myList.Add (10);
         myList.Add (20);
         myList.Add (30);
         myList.Add (40);
         myList.Insert (2, 12);
         list.Add (10);
         list.Add (20);
         list.Add (30);
         list.Add (40);
         list.Insert (2, 12);
         Assert.AreEqual (5, myList.Count);
         Assert.AreEqual (8, myList.Capacity);
         Assert.AreEqual (5, list.Count);
         Assert.AreEqual (8,list.Capacity);
         Assert.AreEqual (myList.Count, list.Count);
         Assert.ThrowsException<IndexOutOfRangeException> (() => myList.Insert (7, 12));
      }
      [TestMethod]
      public void TestRemove () {
         myList.Add (10);
         myList.Add (20);
         myList.Add (30);
         myList.Add (40);
         list.Add (10);
         list.Add (20);
         list.Add (30);
         list.Add (40);
         myList.Remove (10);
         list.Remove (10);
         Assert.AreEqual (list.Count, myList.Count);
         Assert.ThrowsException<InvalidOperationException> (() => myList.Remove (70));
      }
      [TestMethod]
      public void TestRemoveAt () {
         myList.Add (10);
         myList.Add (20);
         myList.Add (30);
         myList.Add (40);
         myList.RemoveAt (2);
         list.Add (10);
         list.Add (20);
         list.Add (30);
         list.Add (40);
         list.RemoveAt (2);
         Assert.AreEqual (3, myList.Count);
         Assert.AreEqual (myList.Count, list.Count);
         Assert.ThrowsException<IndexOutOfRangeException> (() => myList.RemoveAt (6));
      }
   }
}