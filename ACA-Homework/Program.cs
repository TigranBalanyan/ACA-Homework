using System;
using System.Collections.Generic;
using ACA_Homework.Assignment_5;
using ACA_Homework.Assingmnet_4;

namespace ACA_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            RollingDie die = new RollingDie();
            die.a += PrintTwoRowsInARowEvent; //Creating an inctance of a die
            die.OnTwoRowsInARowAccured += PrintTwoRowsInARowEvent; //subscribing to an event
            die.OnSumIsGreateThanOrEqualToTwenthy += PrintSumIsGreateThanOrEqualToTwenthyEvent; //prints an event stack
            die.Roll(); // Rolling the dice

            Console.WriteLine();

            foreach(var x in die.Rollings)
            {
                Console.Write(x + " ");
            }
        }

        /// <summary>
        /// Prints the List of rolling results
        /// </summary>
        /// <param name="numberOfElement">Event parameter that shows the first element number when the event triggers</param>
        /// <param name="numberOfEvents">Shows the number of triggered events</param>
        public static void PrintTwoRowsInARowEvent(int numberOfElement, int numberOfEvents)
        {
            Console.WriteLine("Two Fours in a row event occured! in a  - " + numberOfElement);
            Console.WriteLine("Total Number of Events is "  + numberOfEvents);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e">Who runs the event</param>
        /// <param name="Numbers">Sequence of numbers which sum is greater or equal than 20</param>
        public static void PrintSumIsGreateThanOrEqualToTwenthyEvent(object e, List<int> Numbers)
        {
            Console.Write("Number list that is greater or egaul than 20  - ");
            foreach(var number in Numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
