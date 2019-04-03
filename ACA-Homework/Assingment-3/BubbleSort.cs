using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_3
{
    public class BubbleSort : Algorithm
    {
        public override string Sort(int[] randomArray)
        {
            int temp;
            for (int j = 0; j <= randomArray.Length - 2; j++)
            {
                for (int i = 0; i <= randomArray.Length - 2; i++)
                {
                    if (randomArray[i] > randomArray[i + 1])
                    {
                        temp = randomArray[i + 1];
                        randomArray[i + 1] = randomArray[i];
                        randomArray[i] = temp;
                    }
                }
            }
            return Convert.ToString(randomArray);
        }
    }
}
