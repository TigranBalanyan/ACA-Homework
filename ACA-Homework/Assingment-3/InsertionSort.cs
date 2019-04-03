using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_3
{
    public class InsertionSort : Algorithm
    {
        public override string Sort(int[] randomArray)
        {
            string res = string.Empty;

            for (int i = 0; i < randomArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (randomArray[j - 1] > randomArray[j])
                    {
                        int temp = randomArray[j - 1];
                        randomArray[j - 1] = randomArray[j];
                        randomArray[j] = temp;
                    }
                }
            }

            foreach (var number in randomArray)
            {
                res += Convert.ToString(number) + " ";
            }

            return res;
        }
    }
}
