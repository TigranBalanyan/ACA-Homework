using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACA_Homework.Assignment_1
{
    struct MyType
    {
        private readonly string value;

        public MyType(string value)
        {
            this.value = value;
        }

        public string Value { get { return value; } }

        public static implicit operator MyType(string s)
        {
            return new MyType(s);
        }

        public static implicit operator string(MyType p)
        {
            return p.Value;
        }

    }
}
