using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates.Complex_Classes_1
{
    internal class A
    {
        private double x;
        public A(double x = 0)
        {
            this.x = x;
        }
        public A(A a)
        {
            this.x = a.x;
        }
        public double GetX() { return x; }
        public void SetX(double x) { this.x = x; }
        public override string ToString()
        {
            return $"A: <{x}>";
        }
    }
}
