using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assingment_6
{
    /// <summary>
    /// Simple representation of a student
    /// </summary>
    public class Student
    {
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public Dictionary<string, int> TestResult = new Dictionary<string, int>();

        internal void AddTestResult(string subject, int score)
        {
            this.TestResult.Add(subject, score);
        }
    }
}
