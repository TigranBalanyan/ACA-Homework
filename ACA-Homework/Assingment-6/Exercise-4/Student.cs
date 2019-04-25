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
    internal class Student : IQueryable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string,int> Scores { get; set; }

        public Expression Expression => throw new NotImplementedException();

        public Type ElementType => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        IEnumerator<Student> IEnumerable<Student>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
