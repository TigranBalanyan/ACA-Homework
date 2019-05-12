using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ACA_Homework.Assingment_6;
using ACA_Homework.Assingment_6.Exercise_4;
using ACA_Homework.Assingment_7;
using static ACA_Homework.Assingment_6.Airport;

namespace ACA_Homework
{
    class Program
    {
        private static List<int> source;

        static void Main(string[] args)
        {
            #region ParallelFor

            int fromInclusive = 5;
            int toExclusive = 10;
            Action<int> action = new Action<int>(ActionBody);
            ParalleFor(fromInclusive,toExclusive, action);
            Console.WriteLine();

            #endregion

            #region ParallelForEach

            source = new List<int>();
            source.Add(5);
            source.Add(4);
            Parallel.ForEach<int>(source, ActionBody);
            Console.WriteLine();

            #endregion

            #region ParallelForEachWithOptions

            var parallelOptions = new ParallelOptions(); //created the parallel options

            var numberOfProcessors = Environment.ProcessorCount; //number of processors

            parallelOptions.MaxDegreeOfParallelism = numberOfProcessors + 1; 
            Parallel.ForEach<int>(source, parallelOptions: parallelOptions, ActionBody);

            #endregion
        }

        /// <summary>
        /// Implements the parallel programming
        /// </summary>
        /// <param name="fromInclusive"></param>
        /// <param name="toExclusive"></param>
        /// <param name="action"></param>
        private static void ParalleFor(int fromInclusive, int toExclusive, Action<int> action)
        {
            Parallel.For(fromInclusive, toExclusive, action);
        }

        /// <summary>
        /// Method for printing the number
        /// </summary>
        /// <param name="x"></param>
        public static void ActionBody(int x)
        {
            Console.WriteLine(x + "the Action X"); 
        }
    }
}
