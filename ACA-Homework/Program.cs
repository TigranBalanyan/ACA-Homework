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
            a.RealPart = 5;
            a.ComplexPart = 10.45;
            Complex b = new Complex(5.6, 10.3);
            Console.WriteLine("Addition");
            Console.WriteLine("Real part: " + (a + b).RealPart + " Complex part " +  (a + b).ComplexPart);

            Console.WriteLine("Subtraction");
            Console.WriteLine("Real part: " + (a - b).RealPart + " Complex part " + (a - b).ComplexPart);

            Console.WriteLine("Multiplication");

        }
    }
}
