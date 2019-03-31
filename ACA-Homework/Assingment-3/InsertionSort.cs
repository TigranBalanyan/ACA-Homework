using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_3
{
    public class InsertionSort : IAlgorithm
    {

        public string RunningTime(int[] randomArray)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Sort(randomArray);
            watch.Stop();
            var elapsed = watch.Elapsed;

            return elapsed.ToString();
        }

        public string Sort(int[] randomArray)
        {
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

            string res = string.Empty;
            foreach(var number in randomArray)
            {
                res += Convert.ToString(number) + " ";
            }
            return res;
        }

        public string UsedMemory(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}
