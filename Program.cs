// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ---------------------------------------------------------------------------- CUILib ---
// Program.cs
// Classes TQueue<T>
// Implement a Queue<T> using arrays as the underlying data structure.
// The queue should grow the array when needed (like the TStack above does).
// If the array does not have to be grown, both Enqueue and Dequeue should be constant time (O(1)) operations. Throw exceptions as needed. 
// class TQueue<T> {
// public void Enqueue (T a) { }
// public T Dequeue () { }
// public T Peek () { }
// public bool IsEmpty { get; }
// InvalidOperationException: This exception should be thrown when attempting to dequeue or peek an empty queue.
// ---------------------------------------------------------------------------------------
namespace Training {
   internal class Program {
      static void Main (string[] args) { }
   }

   #region TQueue ------------------------------------------------------------------------
   /// <summary>Create TQueue</summary>
   /// <typeparam name="T">int</typeparam>
   public class TQueue<T> {
      #region Properties --------------------------------------------
      /// <summary>Capacity of the array</summary>
      public int Capacity => mArray.Length;

      /// <summary>Get the number of elements contained in the queue</summary>
      public int Count => mCount;

      /// <summary>The count is zero</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Methods -----------------------------------------------
      /// <summary>Check the empty queue</summary>
      /// <exception cref="InvalidOperationException"></exception>
      void CheckException () {
         if (IsEmpty) throw new InvalidOperationException ("Empty Queue");
      }

      /// <summary>Remove the first-in element on the queue</summary>
      /// <returns>The removed element</returns>
      public T Dequeue () {
         CheckException ();
         T i = mArray[mFirst];
         mArray[mLast] = default;
         mCount--;
         mLast = (mLast + 1) % Capacity;
         return i;
      }

      /// <summary>Add the element on the queue</summary>
      /// <param name="a"></param>
      public void Enqueue (T a) {
         if (Count == Capacity) Array.Resize (ref mArray, mArray.Length * 2);
         mArray[mFirst] = a;
         mCount++;
         mFirst = (mFirst + 1) % Capacity;
      }

      /// <summary>The first-in element on the queue</summary>
      /// <returns>The first-in element of the queue</returns>
      public T Peek () {
         CheckException ();
         Console.WriteLine (mArray[mLast]);
         return mArray[mLast];
      }

      /// <summary>Resizes the array and arranges the elements in the order of first-in to last-in on the resized array</summary>
      public void Resize () {
         var temp = new T[Capacity * 2];
         for (int i = 0; i < Capacity; i++) {
            temp[i] = mArray[mFirst];
            mFirst = (mFirst + 1) % Capacity;
         }
         mArray = temp;
         mFirst = Count;
         mLast = 0;
      }
      #endregion

      #region Private data ------------------------------------------
      /// <summary>Declare and intialize the array</summary>
      T[] mArray = new T[4];
      int mCount = 0;
      int mFirst = 0;
      int mLast = 0;
      #endregion
   }
   #endregion
}
