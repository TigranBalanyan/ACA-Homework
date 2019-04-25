using System;
using System.Collections.Generic;

namespace ACA_Homework.Assingment_6.Exercise_4
{
    internal class StudentSort : IComparer<KeyValuePair<int, Student>>
    {
        public int Compare(KeyValuePair<int, Student> x, KeyValuePair<int, Student> y)
        {
            if (GetAverageForStudent(x.Key) > GetAverageForStudent(y.Key))
            {
                return 1;
            }
            if (GetAverageForStudent(x.Key) < GetAverageForStudent(y.Key))
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private int GetAverageForStudent(int key)
        {
            throw new NotImplementedException();
        }
    }
}