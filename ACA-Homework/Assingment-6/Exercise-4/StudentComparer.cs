using System.Collections;
using System.Collections.Generic;

namespace ACA_Homework.Assingment_6.Exercise_4
{
    public partial class StudentCatalog
    {
        private class StudentComparer : IComparer<Student>
        {
            StudentCatalog students = new StudentCatalog();

            public int Compare(Student x, Student y)
            {
                if (students.GetAverageForStudent(x.Id) > students.GetAverageForStudent(y.Id))
                {
                    return -1;
                }
                if (students.GetAverageForStudent(x.Id) < students.GetAverageForStudent(y.Id))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
