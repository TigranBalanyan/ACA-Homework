using System;
using System.Collections.Generic;
using ACA_Homework.Assignment_5;
using ACA_Homework.Assingment_6;
using ACA_Homework.Assingmnet_4;
using static ACA_Homework.Assingment_6.Airport;

namespace ACA_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            #region Exercise-1

            Console.WriteLine("----------------------------Exercise - 1---------------------------- ");

            OnlineAttendance attendance = new OnlineAttendance(); //creating an Online Attendance class to handle everething
            attendance.OnBannedNames += AlarmTheBannedName; //subscribint to an event
            attendance.Attend();

            #endregion
            */
            /*
            #region Exercise-2

            Console.WriteLine("----------------------------Exercise - 2---------------------------- ");

            Console.WriteLine("Please enter your text");

            string text = Console.ReadLine(); //taking a text

            Abbreviation abb = new Abbreviation(text); //giving text to a class
            Console.WriteLine(abb.Abbreviate()); //abrreviating a text and outputing it

            #endregion
            */

            #region Exercise-3

            List<Airport> airports = new List<Airport>(); //creating a list of airports
            airports.Add(new Airport(Size.Large));      // I am too lazy to give a name to a airport, 
            airports.Add(new Airport(Size.Medium));      //  so I created a constructor that takes 1 parameter 
            airports.Add(new Airport(Size.SuperMega));   //and created several objects to test my programm
            airports.Add(new Airport(Size.Small));
            airports.Add(new Airport(Size.Small));
            airports.Add(new Airport(Size.Medium));
            airports.Add(new Airport(Size.Mega));
            airports.Add(new Airport(Size.Large));
            airports.Add(new Airport(Size.Small));
            airports.Add(new Airport(Size.Large));
            airports.Add(new Airport(Size.SuperMega));
                                                       

            airports.Sort(new AirportComparer());

            foreach(var airport in airports) //prints the airports in descending order
            {
                Console.WriteLine(airport.SizeOfTheAirport);
            }

            #endregion

            #region Exercise-4


            #endregion
        }

        /// <summary>
        /// Spy alarm, in case spy event is raised, and spy entered our site
        /// </summary>
        /// <param name="name">The super secret name of a spy</param>
        private static void AlarmTheBannedName(string name)
        {
            Console.WriteLine($"Achtung the spy {name} entered this site!");
        }
    }
}
