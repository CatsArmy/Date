using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates.Complex_Classes_1
{
    internal class B
    {
        private A a;
        public B(A a) 
        {
            this.a = a;
        }
        public A GetA() { return this.a; }
        public override string ToString()
        {
            return $"B: {this.a}";
        }
    }
}
