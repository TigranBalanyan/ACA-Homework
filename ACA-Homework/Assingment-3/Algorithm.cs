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

        public static string RunningTime()
        {
            return "Running Time";
        }

        public static string UsedMemory()
        {
            return "Used Memory";
        }
    }
}
