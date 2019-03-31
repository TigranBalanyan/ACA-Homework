using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACA_Homework.Assingment_3;

namespace ACA_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of an array that you want to sort");
            int sizeOfAnArray = Convert.ToInt32(Console.ReadLine());

            int[] randomArray = new int[sizeOfAnArray];
            randomArray = ArrayRandomiser(sizeOfAnArray, 10, 100);

            Console.WriteLine("Select which algorithm you want to perform:\n" +
                              "1. Insertion sort\n" +
                              "2. Bubble sort\n" +
                              "3. Quick sort\n" +
                              "4. Heap sort\n" +
                              "5. Merge sort\n" +
                              "6.All");

            string algorithmNumber = Console.ReadLine();

            if (algorithmNumber == string.Empty)
            {
                Console.WriteLine("Please enter the valid number");
                throw new Exception();
            }

            int[] numbersOfAlgorithms = AlgorithmNumbers(algorithmNumber);
            
            var Algorithms = new List<Algorithm>();
            foreach (var i in numbersOfAlgorithms)
            {
                if (i == 1)
                {
                    Algorithms.Add(new InsertionSort());
                }
                if(i == 2)
                {
                    Algorithms.Add(new BubbleSort());
                }
                if(i == 3)
                {
                    Algorithms.Add(new MergeSort());
                }
                if(i == 4)
                {
                    Algorithms.Add(new QuickSort());
                }
                if(i == 5)
                {
                    Algorithms.Add(new HeapSort());
                }
            }

            foreach(var algorithm in Algorithms)
            {
                algorithm.Sort(randomArray);
                Algorithm.RunningTime();
                Algorithm.UsedMemory();
            }
        }

        private static int[] AlgorithmNumbers(string algorithmNumber)
        {
            if (algorithmNumber.Length >= 1 && algorithmNumber.Length <= 3)
            {
                int[] numberOfAlgorithms;

                int firstNumber = Convert.ToInt32(algorithmNumber[0]);

                if (algorithmNumber.Length == 1)
                {
                    numberOfAlgorithms = new int[1];
                    numberOfAlgorithms[0] = firstNumber;
                }
                else
                {
                    int lastNumber = Convert.ToInt32(algorithmNumber[2]);

                    int num;

                    if (lastNumber > firstNumber)
                    {
                        num = lastNumber - firstNumber;
                    }
                    else
                    {
                        num = firstNumber - lastNumber;
                    }

                    numberOfAlgorithms = new int[num + 1];

                    for (int i = 0; i <= num; i++)
                    {
                        numberOfAlgorithms[i] = firstNumber + i;
                        Console.WriteLine(numberOfAlgorithms[i] + " ");
                    }
                }

                return numberOfAlgorithms;
            }
            else
            {
                return null;
            }
        }

        private static int[] ArrayRandomiser(int sizeOfAnArray, int Min, int Max)
        {
            int[] randomArray = new int[sizeOfAnArray];
            Random randNum = new Random();
            for (int i = 0; i < sizeOfAnArray; i++)
            {
                randomArray[i] = randNum.Next(Min, Max);
            }       
            
            return randomArray;
        }
    }
}
