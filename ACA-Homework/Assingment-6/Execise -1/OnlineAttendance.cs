using System;

namespace ACA_Homework
{
    /// <summary>
    /// This class is created for configuring user attendance to site
    /// </summary>
    internal class OnlineAttendance
    {
        public Action<string> OnBannedNames { get; internal set; }  //event for raising in case of spy

        private string Name { get; set; } //the name of the user

        /// <summary>
        /// Runs loop of users untill spy is detected
        /// </summary>
        internal void Attend()
        {
            while(true)
            {
                Console.WriteLine("Please enter your name!");
                this.Name = Console.ReadLine();
                if ((this.Name == "Jack" || this.Name == "Steven" || this.Name == "Mathew") &&  this.OnBannedNames != null) //spy is detected in the site
                {
                    this.OnBannedNames(Name); //sends event for spy detection
                    break;
                }
            }
        }
    }
}