// --------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
// Program.cs
// Classes MYLIST<T>
// public MyList () { } 
// public int Count { get; }
// public int Capacity { get; }
// public T this[int index] { get; set; }
// public void Add (T a) { }
// public bool Remove (T a) { }
// public void Clear () { }
// public void Insert (int index, T a) { }
// public void RemoveAt (int index) { } 
// Implement a custom MyList<T> class using arrays as the underlying data structure.
// The MyList<T> should start with an initial capacity of 4 and double its capacity when needed.
// Use the template shown below for implementation. Throw exceptions when necessary.
// IndexOutOfRangeException: This exception should be thrown when attempting to access an index that is out of the valid range. 
// InvalidOperationException: This exception should be thrown when attempting to remove an item that is not found in the list. 
// --------------------------------------------------------------------------------------------
namespace Training {
   #region Program ------------------------------------------------------------------------------
   /// <summary> Classes MyList<T> </summary>
   internal class Program {
      #region Methods ------------------------------------------------------------------------------
      /// <summary> Create MyList </summary>
      /// <param name="args"></param>
      static void Main (string[] args) {

      }
   }
   public class MyList<T> {
      private T[] array;
      private int count;
      public MyList () {
         array = new T[4];
         count = 0;
      }
      public int Count => count;
      public int Capacity => array.Length;
      public T this[int index] {
         get {
            if (index < 0 || index >= count) throw new IndexOutOfRangeException ("Index is out of the valid range.");
            return array[index];
         }
         set {
            if (index < 0 || index >= count) throw new IndexOutOfRangeException ("Index is out of the valid range.");
            array[index] = value;
         }
      }
      /// <summary> Add the element </summary>
      /// <param name="item"></param>
      public void Add (T item) {
         if (count == array.Length) Array.Resize (ref array, array.Length * 2);
         array[count] = item;
         count++;
      }
      /// <summary> Remove the element </summary>
      /// <param name="item"></param>
      /// <returns></returns>
      /// <exception cref="InvalidOperationException"></exception>
      public bool Remove (T item) {
         int index = Array.IndexOf (array, item, 0, count);
         if (index < 0 || index >= count) throw new InvalidOperationException ("Item not found in the list.");
         for (int i = index; i < count - 1; i++) array[i] = array[i + 1];
         count--;
         array[count] = default;
         return true;
      }
      /// <summary> Clear the element </summary>
      public void Clear () {
         array = new T[4];
         count = 0;
      }
      /// <summary> Insert an element </summary>
      /// <param name="index"></param>
      /// <param name="item"></param>
      /// <exception cref="IndexOutOfRangeException"></exception>
      public void Insert (int index, T item) {
         if (index < 0 || index > count) throw new IndexOutOfRangeException ("Index is out of the valid range.");
         if (count == array.Length) Array.Resize (ref array, array.Length * 2);
         for (int i = count; i > index; i--) array[i] = array[i - 1];
         array[index] = item;
         count++;
      }
      /// <summary> Remove the element at a specific index </summary>
      /// <param name="index"></param>
      /// <exception cref="IndexOutOfRangeException"></exception>
      public void RemoveAt (int index) {
         if (index < 0 || index >= count) throw new IndexOutOfRangeException ("Index is out of the valid range.");
         for (int i = index; i < count - 1; i++) array[i] = array[i + 1];
         count--;
         array[count] = default;
      }
   }
   #endregion 
}
#endregion 


