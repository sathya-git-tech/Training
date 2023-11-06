namespace Training; 
[TestClass]
public class UnitTest1 {
   [TestMethod]
   public void TestAdd () {
      MyList <int> myList = new ();
      myList.Add (10);
      myList.Add (20);   
      myList.Add (30);
      myList.Add (40);
      Assert.AreEqual (4, myList.Count);
      myList.Add (50);
      Assert.AreEqual (8, myList.Capacity );
   }
   [TestMethod]
   public void TestRemove () {
      MyList <int> myList = new ();
      myList.Add (10);
      myList.Add (20);
      myList.Add (30);
      myList.Add (40);
      myList.Remove (10);
      Assert.AreEqual (3, myList.Count);
      Assert.ThrowsException<InvalidOperationException> (() => myList.Remove (70));
   }
   [TestMethod]
   public void TestClear () {
      MyList <int> myList = new ();
      myList.Add (10);
      myList.Add (20);
      myList.Add (30);
      myList.Add (40);
      myList.Clear ();
      Assert.AreEqual (0, myList.Count);
   }
   [TestMethod]
   public void TestInsert () {
      MyList <int> myList = new ();
      myList.Add (10);
      myList.Add (20);
      myList.Add (30);
      myList.Add (40);
      myList.Insert (2, 12);
      Assert.AreEqual (5, myList.Count);
      Assert.AreEqual (8, myList.Capacity);
      Assert.ThrowsException<IndexOutOfRangeException > (() => myList.Insert (7, 12));
   }
   [TestMethod]
   public void TestRemoveAt () {
      MyList <int> myList = new ();
      myList.Add (10);
      myList.Add (20);
      myList.Add (30);
      myList.Add (40);
      myList.RemoveAt (2);
      Assert.AreEqual (3, myList.Count);
      Assert.ThrowsException<IndexOutOfRangeException > ((() => myList.RemoveAt (6)));
   }

}