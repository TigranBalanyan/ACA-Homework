using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_3
{
    public abstract class Algorithm
    {
        public abstract string Sort(int[] array);

        public string RunningTime(int[] array)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Sort(array);
            watch.Stop();
            var elapsed = watch.Elapsed;

            return elapsed.ToString();
        }

        public string UsedMemory()
        {
            long memory = GC.GetTotalMemory(true);
            return Convert.ToString(memory / 1024 + "KBytes");
        }
    }
}
