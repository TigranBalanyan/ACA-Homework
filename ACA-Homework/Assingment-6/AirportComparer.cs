using System.Collections.Generic;
using ACA_Homework.Assingment_6;
using static ACA_Homework.Assingment_6.Airport;

namespace ACA_Homework
{
    /// <summary>
    /// Class for my own sorting logic of a list
    /// </summary>
    internal class AirportComparer : IComparer<Airport>
    {
        public int Compare(Airport x, Airport y) //Compares the airports by it's size
        {
            if(x.SizeOfTheAirport > y.SizeOfTheAirport)
            {
                return -1;
            }
            if(x.SizeOfTheAirport < y.SizeOfTheAirport)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}