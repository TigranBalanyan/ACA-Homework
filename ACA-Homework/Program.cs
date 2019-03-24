using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ACA_Homework.Assignment_1.Assignment_1;

namespace ACA_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex();
            a.RealPart = 4;
            a.ComplexPart = 16.8;
            Complex b = new Complex(7.3, 5.9);

            Console.WriteLine("Addition");
            Console.WriteLine("Real part: " + (a + b).RealPart + " Complex part " +  (a + b).ComplexPart);

            Console.WriteLine("Subtraction");
            Console.WriteLine("Real part: " + (a - b).RealPart + " Complex part " + (a - b).ComplexPart);

            Console.WriteLine("Multiplication");
            Console.WriteLine("Real part: " + (a * b).RealPart + " Complex part " + (a * b).ComplexPart);

            Console.WriteLine("Division");
            Console.WriteLine("Real part: " + (a / b).RealPart + " Complex part " + (a / b).ComplexPart);

            Console.WriteLine("Magnitude");
            Console.WriteLine(Complex.Magnitude(a));

        }
    }
}
