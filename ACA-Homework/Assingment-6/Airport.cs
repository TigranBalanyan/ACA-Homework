using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_6
{
    /// <summary>
    /// Class represents an airport      
    /// </summary> 
    public partial class Airport
    {
        public Airport(string name, string countryCode, Size sizeOfTheAirport)
        {
            Name = name;
            CountryCode = countryCode;
            SizeOfTheAirport = sizeOfTheAirport;
        }
        public Airport(Size sizeOfTheAirport) 
        {
            SizeOfTheAirport = sizeOfTheAirport;
        }

        public string Name { get; set; }
        public string CountryCode { get; set; }
        public Size SizeOfTheAirport { get; set; }
    }
}
