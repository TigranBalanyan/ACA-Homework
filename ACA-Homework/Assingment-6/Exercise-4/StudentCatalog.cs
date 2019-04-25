using System;
using System.Collections.Generic;
using System.Linq;

namespace ACA_Homework.Assingment_6.Exercise_4
{
    internal class StudentCatalog
    {
        private Dictionary<int, Student> Students { get; set; }

        public StudentCatalog()
        {
            Students = new Dictionary<int, Student>();
        }

        /// <summary>
        /// Addina a single student to a catalog
        /// </summary>
        /// <param name="aStudent">A simple student</param>
        public void AddStudent(Student aStudent)
        {
            Students.Add(aStudent.Id, aStudent);
        }

        /// <summary>
        ///Given an id, return the student with that id.
        /// If no student exists with the given id, return null. 
        /// </summary>
        /// <param name="id">The given id</param>
        /// <returns></returns>
        public Student GetStudent(int id)
        {
            if (Students.ContainsKey(id))
            {
                return Students[id];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///  Given an id, return the score average for the student with that id
        ///   If no student exists with the given id, return -1.
        /// </summary>
        /// <param name="id">The given id</param>
        /// <returns></returns>
        public int GetAverageForStudent(int id)
        {
            if (Students.ContainsKey(id))
            {
                int studentAverageScore = 0;
                foreach (var student in Students)
                {
                    if (student.Key == id)
                    {
                        int score;
                        score = student.Value.Scores.Sum(x => x.Value); //used some LINQ 
                        studentAverageScore += score;
                    }
                }
                return studentAverageScore;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Returns the total test score average for ALL students in the catalog. 
        /// Note that only students with a "real" score average (i.e. NOT -1) should 
        /// be included in the calculation of the average. 
        /// </summary>
        /// <returns></returns>
        public int GetTotalAverage()
        {
            int totalAverageScoreForStudents = 0;
            int studentAverageScore;
            foreach (var student in Students)
            {
                studentAverageScore = GetAverageForStudent(student.Key);
                if (studentAverageScore != -1)
                {
                    totalAverageScoreForStudents += studentAverageScore;
                }
            }
            return totalAverageScoreForStudents;
        }

        /// <summary>
        /// Get top three students who have the highest average score. 
        /// If no student returns empty list. 
        /// </summary>
        /// <returns></returns>
        public List<Student> GetTopThreeStudents()
        {
            var topStudents = Students.ToList(); //why I love vars :)))
            topStudents.Sort(new StudentSort());

            if (Students.Count() >= 3)
            {
                return topStudents.Take<Student>(3, Classes);
            }
            else
            {
                return null;
            }

        }

        private interface IClasses : IQueryable<Student>
        {

        }
    }
}
