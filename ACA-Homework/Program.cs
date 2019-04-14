using System;
using ACA_Homework.Assignment_5;
using ACA_Homework.Assingmnet_4;

namespace ACA_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            RollingDie die = new RollingDie(); //Creating an inctance of a die
            die.OnTwoRowsInARowAccured += PrintTwoRowsInARowEvent; //subscribing to an event
            die.Roll(); // Rolling the dice

            Console.WriteLine();

            foreach(var x in die.Rollings)
            {
                Console.Write(x + " ");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberOfElement">Event parameter that shows the first element number when the event triggers</param>
        /// <param name="numberOfEvents">Shows the number of triggered events</param>
        public  static void PrintTwoRowsInARowEvent(int numberOfElement, int numberOfEvents)
        {
            Console.WriteLine("Two Fours in a row event occured! in a " + numberOfElement);
            Console.WriteLine("Total Number of Events is "  + numberOfEvents);
        }
    }
}
