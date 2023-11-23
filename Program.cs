// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ---------------------------------------------------------------------------- CUILib ---
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
// ---------------------------------------------------------------------------------------
using System;
namespace Training {
   internal class Program {
      static void Main (string[] args) { }
   }

   #region MyList ------------------------------------------------------------------------
   /// <summary>Create MyList</summary>
   /// <typeparam name="T"></typeparam>
   public class MyList<T> {
      #region Properties --------------------------------------------
      /// <summary>Capacity of the array</summary>
      public int Capacity => mArray.Length;

      /// <summary>Count of the array</summary>
      public int Count => mCount;

      /// <summary>Check the index out of range exception</summary>
      /// <param name="index"></param>
      /// <returns>Return the items from list using its index</returns>
      public T this[int index] {
         get {
            CheckException (index);
            return mArray[index];
         }
         set {
            CheckException (index);
            mArray[index] = value;
         }
      }
      #endregion

      #region Methods -----------------------------------------------
      /// <summary>Add all the elements</summary>
      /// <param name="item"></param>
      public void Add (T item) {
         Resize ();
         mArray[mCount++] = item;
      }

      /// <summary>Check the index out of range exception</summary>
      /// <param name="index"></param>
      /// <returns>Represents a Boolean (true or false) value</returns>
      /// <exception cref="IndexOutOfRangeException"></exception>
      public bool CheckException (int index) {
         if (index < 0 || index >= mCount) throw new IndexOutOfRangeException ("Index is out of the valid range.");
         return true;
      }

      /// <summary>Clear all the element</summary>
      public void Clear () {
         Array.Clear (mArray, 0, mCount);
         mCount = 0;
      }

      /// <summary>Insert an element</summary>
      /// <param name="index"></param>
      /// <param name="item"></param>
      /// <exception cref="IndexOutOfRangeException"></exception>
      public void Insert (int index, T item) {
         CheckException (index);
         Resize ();
         for (int i = mCount; i > index; i--) mArray[i] = mArray[i - 1];
         mArray[index] = item;
         mCount++;
      }

      /// <summary>Remove the element</summary>
      /// <param name="item"></param>
      /// <returns>Represents a Boolean (true or false) value</returns>
      public bool Remove (T item) {
         int index = Array.IndexOf (mArray, item, 0, mCount);
         for (int i = index; i < mCount - 1; i++) mArray[i] = mArray[i + 1];
         mArray[--mCount] = default;
         return true;
      }

      /// <summary>Remove the element at a specific index</summary>
      /// <param name="index"></param>
      /// <exception cref="ArgumentOutOfRangeException"></exception>
      public void RemoveAt (int index) {
         if (index < 0 || index >= mCount) throw new ArgumentOutOfRangeException (nameof (index));
         Remove (mArray[index]);
      }

      /// <summary>Resize the array</summary>
      public void Resize () {
         if (mCount == mArray.Length) Array.Resize (ref mArray, mArray.Length * 2);
      }
      #endregion

      #region Private data ------------------------------------------
      /// <summary>Declare and initialize the array</summary>
      T[] mArray = new T[4];
      int mCount = 0;
      #endregion
   }
   #endregion 
}