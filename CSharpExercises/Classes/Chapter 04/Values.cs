using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_04
{
    public class Values
    {
        public double value1 = default;
        public double value2 = default;
        public double result = default;
        public char @operator = default;

        public Values(double value1, double value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }
    }
}
