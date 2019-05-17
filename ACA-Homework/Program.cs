using ACA_Homework.Assingment_9;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACA_Homework
{
    class Program
    {
        private static List<int> source;

        static void Main(string[] args)
        {

            #region ParallelFor

            int fromInclusive = Convert.ToInt32(Console.Read());
            int toExclusive = Convert.ToInt32(Console.Read());

            MyParallel.ParallelFor(fromInclusive, toExclusive, Method);

            #endregion

            #region ParallelForEach

            source = new List<int>();
            source.Add(5);
            source.Add(4);
            MyParallel.ForEach<int>(source, Method);
            Console.WriteLine();

            #endregion

            #region ParallelForEachWithOptions

            var parallelOptions = new ParallelOptions(); //created the parallel options

            var numberOfProcessors = Environment.ProcessorCount; //number of processors

            parallelOptions.MaxDegreeOfParallelism = numberOfProcessors + 1; 
            MyParallel.ForEach<int>(source, parallelOptions, Method);

            #endregion
        }

        /// <summary>
        /// Some basic method
        /// </summary>
        /// <param name="obj"></param>
        private static void Method(int obj)
        {
            obj++;
            Console.WriteLine(obj + "our value"); //does something
        }

    }
}
