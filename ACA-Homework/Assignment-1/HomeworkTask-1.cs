using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assignment_1
{
    public class Assignment_1
    {
        public struct Complex
        {
            public double RealPart { get; set; }
            public double ComplexPart { get; set; }

            public Complex(double realPart, double complexPart)
            {
                RealPart = realPart;
                ComplexPart = complexPart;
            }

            public static Complex operator+ (Complex a, Complex b)
            {
                Complex res = new Complex
                {
                    RealPart = a.RealPart + b.RealPart,
                    ComplexPart = a.ComplexPart + b.ComplexPart
                };

                return res;
            }

            public static Complex operator- (Complex a, Complex b)
            {
                Complex res = new Complex
                {
                    RealPart = a.RealPart - b.RealPart,
                    ComplexPart = a.ComplexPart - b.ComplexPart
                };

                return res;
            }

            /// <summary>
            /// (a+bi)*(c+di) = a*c + a*di + c*bi - b*d implememted simple multiplication algorithm
            /// </summary>
            public static Complex operator* (Complex a, Complex b)
            {
                Complex res = new Complex
                {
                    //(a+bi)*(c+di) = a*c + a*di + c*bi - b*d
                    RealPart = (a.RealPart * b.RealPart) - (a.ComplexPart * b.ComplexPart),
                    ComplexPart = (a.RealPart * b.ComplexPart) + (a.ComplexPart * b.RealPart)
                };

                return res;
            }

            /// <summary>
            /// a = a1 + a2*i
            /// b = b1 + b2*i
            /// a / b =(a1 + a2*i)*(b1 - b2*i)/(b1^2 + b2^2) 
            /// conjugate = (b1 - b2*i) the conjugate
            /// </summary>
            public static Complex operator/ (Complex a, Complex b)
            {
                Complex conjugate = new Complex(b.RealPart, (-1) * b.ComplexPart); //finding a conjugate number
                Complex c = a * conjugate; 
                double downNumber = Math.Pow(b.RealPart, 2) +  Math.Pow(b.ComplexPart,2);
                Complex res = new Complex
                {
                    RealPart = c.RealPart / downNumber,
                    ComplexPart = c.ComplexPart / downNumber
                };

                return res;
            }

            /// <summary>
            /// |a + b*i| = sqrt(a-^2 + b^2)  
            /// </summary>
            public static double Magnitude(Complex a)
            {
                return Math.Sqrt(Math.Pow(a.RealPart, 2) + Math.Pow(a.ComplexPart, 2));  
            }
        }
    }
}
