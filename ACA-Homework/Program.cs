using System;
using System.Collections.Generic;
using ACA_Homework.Assingment_6;
using ACA_Homework.Assingment_6.Exercise_4;
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

            /*
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
            */

            #region Exercise-4

            StudentCatalog students = new StudentCatalog(); //Creating a student catalog

            Student anna = new Student(12, "Anna"); 
            Student betty = new Student(338, "Betty");
            Student carl = new Student(92, "Carl");
            Student diana = new Student(295, "Diana");

            anna.AddTestResult("English", 85);
            anna.AddTestResult("Math", 70);
            anna.AddTestResult("Biology", 90);
            anna.AddTestResult("French", 52);

            betty.AddTestResult("English", 77);
            betty.AddTestResult("Math", 82);
            betty.AddTestResult("Chemistry", 65);
            betty.AddTestResult("French", 41);

            carl.AddTestResult("English", 55);
            carl.AddTestResult("Math", 48);
            carl.AddTestResult("Biology", 70);
            carl.AddTestResult("French", 38);

            students.AddStudent(anna);
            students.AddStudent(betty);
            students.AddStudent(carl);
            students.AddStudent(diana);

            Console.WriteLine(students.GetStudent(12).Name); //Getting student by Id

            Console.WriteLine(students.GetAverageForStudent(338)); //Getting the average score for a student by id

            Console.WriteLine(students.GetTotalAverage()); //Getting the total average of a student's score


            foreach(var bestStudent in students.GetTopThreeStudents())
            {
                Console.WriteLine(bestStudent.Name + " - average score is " + students.GetAverageForStudent(bestStudent.Id)); //printing the names of top students and their scores
            }

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
