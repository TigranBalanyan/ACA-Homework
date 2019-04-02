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

            List<int> numbersOfAlgorithms = AlgorithmNumbers(algorithmNumber);

            if (numbersOfAlgorithms != null)
            {
                var Algorithms = new List<IAlgorithm>();

                foreach (var i in numbersOfAlgorithms)
                {
                    switch (i)
                    {
                        case 1: 
                            Algorithms.Add(new InsertionSort());
                            break;
                        case 2:
                            Algorithms.Add(new BubbleSort());
                            break;
                        case 3:
                            Algorithms.Add(new QuickSort());
                            break;
                        case 4:
                            Algorithms.Add(new HeapSort());
                            break;
                        case 5:
                            Algorithms.Add(new MergeSort());
                            break;
                        default:
                            Console.WriteLine("Please, enter the valid numbers!");
                            break;
                    }
                }

                foreach (var algorithm in Algorithms)
                {
                    Console.WriteLine(algorithm.Sort(randomArray));
                    Console.WriteLine();
                    //  algorithm.UsedMemory(randomArray);
                }
            }
            else
            {
                Console.WriteLine("Please, enter the valid numbers!");
            }
        }

        private static List<int> AlgorithmNumbers(string algorithmNumber)
        {
            try
            {
                if (algorithmNumber.Length == 1 || algorithmNumber.Length == 3)
                {
                    List<int> numberOfAlgorithms = new List<int>();

                    if (algorithmNumber.Contains('6'))
                    {
                        numberOfAlgorithms.Add(1);
                        numberOfAlgorithms.Add(2);
                        numberOfAlgorithms.Add(3);
                        numberOfAlgorithms.Add(4);
                        numberOfAlgorithms.Add(5);

                        return numberOfAlgorithms;
                    }

                    if (algorithmNumber.Length == 1)
                    {
                        numberOfAlgorithms.Add(Convert.ToInt32(algorithmNumber[0]) - 48);
                        return numberOfAlgorithms;
                    }
                    else
                    {
                        int firstNumber = Convert.ToInt32(algorithmNumber[0]) - 48;
                        int lastNumber = Convert.ToInt32(algorithmNumber[2]) - 48;

                        if(firstNumber > 5 || lastNumber > 5)
                        {
                            return null;
                        }

                        if (algorithmNumber[1] == ',')
                        {
                            numberOfAlgorithms.Add(firstNumber);
                            numberOfAlgorithms.Add(lastNumber);

                            return numberOfAlgorithms;
                        }
                        if (algorithmNumber[1] == '-')
                        {
                            for (int i = firstNumber; i <= lastNumber; i++)
                            {
                                numberOfAlgorithms.Add(i);
                                Console.WriteLine(i);
                            }

                            return numberOfAlgorithms;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Source + "Format is invalid");
            }

            return null;
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
