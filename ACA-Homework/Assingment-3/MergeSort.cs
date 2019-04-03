using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_3
{
    public class MergeSort : Algorithm
    {
        public override string Sort(int[] randomArray)
        {
            if (randomArray.Length <= 1)
            {
                    return Convert.ToString(randomArray);
            }

            return null;

        }
    }
}
