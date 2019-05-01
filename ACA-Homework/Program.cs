using System;
using System.Collections.Generic;
using ACA_Homework.Assingment_6;
using ACA_Homework.Assingment_6.Exercise_4;
using ACA_Homework.Assingment_7;
using static ACA_Homework.Assingment_6.Airport;

namespace ACA_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var multiMap = new MultiMap<int, string>(); //initalizing an object
            multiMap.Add(5, "Hello"); //adding a value to key
            multiMap.Add(6, " hey!"); 
            
            PrintMultiMapKeys(multiMap);
            PrintMultiMapValues(multiMap);
           
           
        }

        public static void PrintMultiMapKeys(MultiMap<int, string> multiMap)
        {
            if (multiMap.Keys != null)
            {
                foreach (var memberKey in multiMap.Keys)
                {
                    Console.WriteLine(memberKey + " the MultiMap key.");
                }
            }
        }

        public static void PrintMultiMapValues(MultiMap<int, string> multiMap)
        {
            if(multiMap.Values != null)
            {
                foreach (var memberValue in multiMap.Values)
                {
                    Console.WriteLine(memberValue + " the MultiMap value.");
                }
            }
        }
    }
}
