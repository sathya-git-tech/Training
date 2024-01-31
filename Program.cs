// ---------------------------------------------------------------------------------------
// Training ~ A training program for new interns at Metamation, Batch - July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------- Training -
// Program.cs
// Design and implement a ComplexNumber class that supports the addition and subtraction
// Of complex numbers using operators and can calculate the norm of a complex number.  
// Provide a constructor to initialize a complex number with given real and
// Imaginary parts Overload the + and - operators to enable addition and subtraction of
// Two complex numbers. Have a property Norm to return the norm (magnitude) of the
// Complex number using the formula:a2 + b2−−−−−−√a2 + b2 wherea + ib is a complex number. 
// ---------------------------------------------------------------------------------------

namespace Training {
   #region Program --------------------------------------------------------------------------------
   /// <summary>ComplexNumber</summary>
   internal class Program {
      static void Main (string[] args) {
         Console.Write ("Enter real part of first complex number : ");
         double real1 = double.Parse (Console.ReadLine ());
         Console.Write ("Enter imaginary part of first complex number : ");
         double imag1 = double.Parse (Console.ReadLine ());
         Console.Write ("Enter real part of second complex number : ");
         double real2 = double.Parse (Console.ReadLine ());
         Console.Write ("Enter imaginary part of second complex number : ");
         double imag2 = double.Parse (Console.ReadLine ());
         ComplexNumber c1 = new (real1, imag1);
         ComplexNumber c2 = new (real2, imag2);
         ComplexNumber sum = c1 + c2;
         ComplexNumber diff = c1 - c2;
         Console.WriteLine ("Sum: " + sum.Real + " + " + sum.Imaginary + "i");
         Console.WriteLine ("Difference: " + diff.Real + " - " + diff.Imaginary + "i");
         Console.WriteLine ($"Norm of c1: {c1.Norm}");
         Console.WriteLine ($"Norm of c2: {c2.Norm}");
      }
   }
   #endregion

   #region ComplexNumber --------------------------------------------------------------------------
   /// <summary>Create a ComplexNumber class</summary>
   public class ComplexNumber {
      public double Real;
      public double Imaginary;

      #region Properties --------------------------------------------
      /// <summary>Which calculates the norm (magnitude) of the complex number</summary>
      public double Norm => Math.Sqrt (Real * Real + Imaginary * Imaginary);
      #endregion

      #region Constructor -------------------------------------------
      /// <summary>Create a class constructor with a parameter</summary>
      /// <param name="real">Real part of the complex number</param>
      /// <param name="imaginary">Imaginary part of the complex number</param>
      public ComplexNumber (double real, double imaginary) {
         Real = real;
         Imaginary = imaginary;
      }
      #endregion

      #region Methods -----------------------------------------------
      /// <summary>Adition and subraction of two complex numbers</summary>
      /// <param name="c1"></param>
      /// <param name="c2"></param>
      /// <returns></returns>
      public static ComplexNumber operator + (ComplexNumber c1, ComplexNumber c2) {
         return new ComplexNumber (c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
      }

      public static ComplexNumber operator - (ComplexNumber c1, ComplexNumber c2) {
         return new ComplexNumber (c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
      }
      #endregion
   }
   #endregion
}