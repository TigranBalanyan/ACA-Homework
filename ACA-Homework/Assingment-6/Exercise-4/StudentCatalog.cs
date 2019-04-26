using System;
using System.Collections.Generic;
using System.Linq;

namespace ACA_Homework.Assingment_6.Exercise_4
{
    public partial class StudentCatalog
    {
        public Dictionary<int, Student> StudentsCatalog { get; set; }

        public StudentCatalog()
        {
            StudentsCatalog = new Dictionary<int, Student>();
        }

        /// <summary>
        /// Addina a single student to a catalog
        /// </summary>
        /// <param name="student">A simple student</param>
        public void AddStudent(Student student)
        {
            StudentsCatalog.Add(student.Id, student);
        }

        /// <summary>
        ///Given an id, return the student with that id.
        /// If no student exists with the given id, return null. 
        /// </summary>
        /// <param name="id">The given id</param>
        /// <returns></returns>
        public Student GetStudent(int id)
        {
            if (StudentsCatalog.ContainsKey(id))
            {
                return StudentsCatalog[id];
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
            if (StudentsCatalog.ContainsKey(id))
            {
                int studentAverageScore = 0;
                foreach (var student in StudentsCatalog)
                {
                    if (student.Key == id)
                    {
                        int score;
                        score = student.Value.TestResult.Sum(x => x.Value); //used some LINQ 

                        if (student.Value.TestResult.Count() > 0)
                        {
                            studentAverageScore += score / student.Value.TestResult.Count();
                        }
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
            foreach (var student in this.StudentsCatalog)
            {
                studentAverageScore = GetAverageForStudent(student.Key);

                if (studentAverageScore != -1)
                {
                    totalAverageScoreForStudents += studentAverageScore;
                }
            }
            return totalAverageScoreForStudents/this.StudentsCatalog.Count();
        }

        /// <summary>
        /// Get top three students who have the highest average score.
        /// If no student returns empty list. 
        /// </summary>
        /// <returns></returns>
        public List<Student> GetTopThreeStudents()
        {
            var studentsList = new List<Student>(); //this logic is very bad, I don't like it, but it's the easiues way

            var topThreeStudentsList = new List<Student>();

            foreach(var student in this.StudentsCatalog)
            {
                studentsList.Add(student.Value);
            }

            studentsList.Sort(new StudentComparer());

            for (int i = 0; i < 3; i++)
            {
                topThreeStudentsList.Add(studentsList[i]);
            }

            return topThreeStudentsList;
        }
    }
}
