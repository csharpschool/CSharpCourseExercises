using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpExercises.Classes.Chapter_04
{
    public static class CalculatorExtensions
    {
        public static string Output(this Values values) 
        {
            return $"{values.value1} {values.@operator} {values.value2} = {values.result}";
        }

        public static Values Add(this Values values)
        {
            values.result = values.value1 + values.value2;
            values.@operator = '+';
            return values;
        }

        public static Values Subtract(this Values values)
        {
            values.result = values.value1 - values.value2;
            values.@operator = '-';
            return values;
        }

        public static Values Divide(this Values values)
        {
            values.result = values.value1 / values.value2;
            values.@operator = '/';
            return values;
        }

        public static Values Multiply(this Values values)
        {
            values.result = values.value1 * values.value2;
            values.@operator = 'x';
            return values;
        }
    }
}
