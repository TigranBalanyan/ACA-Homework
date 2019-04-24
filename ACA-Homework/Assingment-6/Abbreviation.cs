using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ACA_Homework
{
    internal class Abbreviation
    {

        private StringBuilder StringBuilder { get; set; } //the string builder class inctance to manipulate in my code
        
        public string Text { get; set; } //inputed text for abbreviateion
         
        public Abbreviation(string Text) 
        {
            this.Text = Text;
        }

        /// <summary>
        /// Method for abrriviating the string
        /// </summary>
        /// <returns></returns>
        internal string Abbreviate() 
        {
            StringBuilder = new StringBuilder();   //constricting a string builder
            string abbreviatedString;
            char[] list = { ' ', '.' };   //we must split our original string to parts with this charachters for abrreviation

            string[] Splitedstring = this.Text.Split(list); //splitted the original string in to parts
            for (int i = 0; i < Splitedstring.Length; i++)
            {
                StringBuilder.Append(Splitedstring[i][0]); //appending every first charchter of a splitted string
            } 

            abbreviatedString = StringBuilder.ToString().ToUpper(); // making final result uppercase

            return abbreviatedString;
        }
    }
}