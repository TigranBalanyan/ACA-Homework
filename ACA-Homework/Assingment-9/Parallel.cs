using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_9
{
    public static class MyParallel
    {
        public static void ParallelFor(int fromInclusive, int toExclusive, Action<int> body)
        {
            for (int i = fromInclusive; i < toExclusive; i++)
            {
                ThreadPool.QueueUserWorkItem((item) =>
                {
                    body((int)item); 
                }, i);
            }
        }

        internal static void ForEach<T>(List<T> source, ParallelOptions parallelOptions, Action<T> actionBody)
        {


        }

        internal static void ForEach<T>(IEnumerable<T> items, Action<T> method)
        {
            if(items == null || method == null)
            {
                Console.WriteLine("invalid methods");
            }

            var resetEvents = new List<ManualResetEvent>();

            foreach (var item in items)
            {
                var evt = new ManualResetEvent(false);
                ThreadPool.QueueUserWorkItem((i) =>    //lambda method
                {
                    method((T)i);
                    evt.Set();
                }, item);
                resetEvents.Add(evt);
            }

            foreach (var re in resetEvents)
                re.WaitOne();
        }
    }
}
