// Project Prolog
// Name: Caleb Baker
// CS3260 Section 001
// Project: Lab_03
// Date: 08/28/2018
// Purpose: Program creates a GUI for the user to do aritmatic on complex numbers
//
// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexArithmeticCalculator
{
    ///<summary>
    /// This class declares all the methods
    /// used to do the complex number
    /// Arithmetic math./// </summary>
    class ComplexArithmetic
    {
        /// <summary>
        /// Purpose: To add the ruturn of the addition aritmatic
        /// </summary>
        /// <param name="op1">any valid ComplexData Value</param>
        /// <param name="op2">any valid ComplexData Value</param>
        /// <returns>op1 + op2</returns>
        public ComplexData Add(ComplexData x, ComplexData y)
        {
            double real = x.Real + y.Real;
            double img = x.Imaginary + y.Imaginary;
            ComplexData value = new ComplexData(real, img);
            return value;
        }

        /// <summary>
        /// Purpose: To add the ruturn of the subtraction aritmatic
        /// </summary>
        /// <param name="op1">any valid ComplexData Value</param>
        /// <param name="op2">any valid ComplexData Value</param>
        /// <returns>op1 - op2</returns>
        public ComplexData Subtract(ComplexData x, ComplexData y)
        {
            double real = x.Real - y.Real;
            double img = x.Imaginary - y.Imaginary;
            ComplexData value = new ComplexData(real, img);
            return value;
        }

        /// <summary>
        /// Purpose: To add the ruturn of the multiplication aritmatic
        /// </summary>
        /// <param name="op1">any valid ComplexData Value</param>
        /// <param name="op2">any valid ComplexData Value</param>
        /// <returns>op1 * op2</returns>
        public ComplexData Multiply(ComplexData x, ComplexData y)
        {
            double real = (x.Real * y.Real) - (x.Imaginary * y.Imaginary);
            double img = (x.Real * y.Imaginary) + (y.Real * x.Imaginary);
            ComplexData value = new ComplexData(real, img);
            return value;
        }

        /// <summary>
        /// Purpose: To add the ruturn of the division aritmatic
        /// </summary>
        /// <param name="op1">any valid ComplexData Value</param>
        /// <param name="op2">any valid ComplexData Value</param>
        /// <returns>op1 / op2</returns>
        public ComplexData Divide(ComplexData x, ComplexData y)
        {
            double topReal = (x.Real * y.Real) + (x.Imaginary * y.Imaginary);
            double topImg = (x.Real * (-1 * y.Imaginary)) + (y.Real * x.Imaginary);
            double bottomValue = (y.Real * y.Real) - (y.Imaginary * (-1 * y.Imaginary));
            double real = topReal / bottomValue;
            double img = topImg / bottomValue;
            ComplexData value = new ComplexData(real, img);
            return value;
        }
    }

    ///<summary>
    /// This class declares the Complex Number type
    /// for system to declare the real and imaginary
    /// numbers of the object/// </summary>
    class ComplexData
    {
        public double Real;
        public double Imaginary;

        public ComplexData(double real, double imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }

        public override string ToString()
        {
            string sign = " + ";
            if(Imaginary < 0)
            {
                sign = " - ";
                Imaginary *= -1;
            }
            return Real.ToString() + sign + Imaginary.ToString() + "i";
        }
    }
}
