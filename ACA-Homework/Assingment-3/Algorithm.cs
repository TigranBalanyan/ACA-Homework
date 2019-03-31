using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_3
{
    public interface IAlgorithm
    {
        string Sort(int[] array);

        string RunningTime(int[] array);

        string UsedMemory(int[] array);
    }
}
