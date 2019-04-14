using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assignment_5
{
    /// <summary>
    /// This class simulates a rolling dies
    /// </summary>
    internal class RollingDie
    {
        public List<int> Rollings { get; set; }
        public delegate void TwoFoursInARow(int numberOfElement, int numberOfEvents);
        public event TwoFoursInARow OnTwoRowsInARowAccured;

        public delegate void SumIsGreateThanOrEqualToTwenthy(int x);
        public event SumIsGreateThanOrEqualToTwenthy OnSumIsGreateThanOrEqualToTwenthy;

        /// <summary>
        ///Initalising a list of a dies outcome 
        /// </summary>
        public RollingDie()
        {
            this.Rollings = new List<int>(); 
        }

        /// <summary>
        /// Createing a list of a dies outcomes, and creating an events for the certain situations
        /// </summary>
        public void Roll()
        {
            Random numbers = new Random();
            int rollResult;
            int k = 0;
            for (int i = 0; i < 50; i++)
            {
                rollResult = numbers.Next(1, 6);
                Rollings.Add(rollResult);
                if(i > 1 && Rollings[i] == 4 && Rollings[i - 1] == 4 && this.OnTwoRowsInARowAccured != null)
                {
                    this.OnTwoRowsInARowAccured(i - 1, ++k);
                }
            }
        }
    }
}
