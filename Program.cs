// ----------------------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.                                              
// ------------------------------------------------------------------------
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
// ----------------------------------------------------------------------------------------------------
namespace Training {
   internal class Program {
      static void Main (string[] args) { }
   }


   #region TQueue -------------------------------------------------------------------------------------
   /// <summary>Create TQueue</summary>
   /// <typeparam name="T"> Datatype </typeparam>
   public class TQueue<T> {
      #region Properties ------------------------------------------------------------------------------
      /// <summary>Length of the array</summary>
      public int Capacity  = 4;

      /// <summary>Count of the array</summary>
      public int Count => mCount;

      /// <summary>The count is zero</summary>
      public bool IsEmpty => mCount == 0;
      #endregion

      #region Methods ---------------------------------------------------------------------------------
      /// <summary>Check the empty queue</summary>
      /// <exception cref="InvalidOperationException"></exception>
      void CheckException () {
         if (IsEmpty) throw new InvalidOperationException ("Empty Queue");
      }

      /// <summary>Remove the first-in element on the queue</summary>
      /// <returns>The removed element</returns>
      public T Dequeue () {
         CheckException ();
         T i = mArray[mFront];
         mArray[mRear] = default;
         mCount--;
         mRear = (mRear + 1) % Capacity;
         return i;
      }

      /// <summary>Add the element on the queue</summary>
      /// <param name="a"></param>
      public void Enqueue (T a) {
         if (Count == Capacity) Array.Resize (ref mArray, mArray.Length * 2);
         mArray[mFront] = a;
         mCount++;
         mFront = (mFront + 1) % Capacity;
      }

      /// <summary>The first-in element on the queue</summary>
      /// <returns>The first-in element of the queue</returns>
      public T Peek () {
         CheckException ();
         Console.WriteLine (mArray[mRear]);
         return mArray[mRear];
      }

      /// <summary>Resizes the array and arranges the elements in the order of first-in to last-in on the resized array</summary>
      public void Resize () {
         var temp = new T[Capacity * 2];
         for (int i = 0; i < Capacity; i++) {
            temp[i] = mArray[mFront];
            mFront = (mFront + 1) % Capacity;
         }
         mArray = temp;
         Capacity *= 2;
         mFront = Count;
         mRear = 0;
      }
      #endregion 

      #region Private data ----------------------------------------------------------------------------
      /// <summary>Declare and intialize the array</summary>
      T[] mArray = new T[4];
      int mCount = 0;
      int mFront = 0;
      int mRear = 0;
      #endregion
   }
   #endregion
}

