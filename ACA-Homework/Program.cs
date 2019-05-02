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
            var list = new List<string>();
            list.Add("Hello");
            var multiMap = new MultiMap<int, string>(); //initalizing an object
            multiMap.Add(5, list); //adding a value to key
            list.Add(" World!");
            multiMap.Add(6, list);

            PrintMultiMapKeys(multiMap);
            PrintMultiMapValues(multiMap);

            Console.WriteLine();

            var outputList = new List<string>();
            multiMap.TryGetValue(5, out outputList); //checking the TryGetValue implementation

            foreach(var item in outputList)
            {
                Console.WriteLine(item + "the values of the key ");
            }

            Console.WriteLine();
            var checkList = new List<string>();
            checkList.Add("Hello");
            Console.WriteLine(multiMap.Contains(new KeyValuePair<int, List<string>>(5, checkList))); //checks is the multimap 
                                                                                                     // contains the keyvalue

            Console.WriteLine();
            multiMap.Remove(6);
            PrintMultiMapKeys(multiMap); //checks if the MultiMap contains the key



        }

        /// <summary>
        /// Prints the MultiMap keys
        /// </summary>
        /// <param name="multiMap"></param>
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

        /// <summary>
        /// Prints the MultiMap values
        /// </summary>
        /// <param name="multiMap"></param>
        public static void PrintMultiMapValues(MultiMap<int, string> multiMap)
        {
            if(multiMap.Values != null)
            {
                foreach (var memberValueList in multiMap.Values)
                {
                    foreach(var value in memberValueList)
                    {
                        Console.WriteLine(value + " the MultiMap value.");
                    }
                }
            }
        }
    }
}
