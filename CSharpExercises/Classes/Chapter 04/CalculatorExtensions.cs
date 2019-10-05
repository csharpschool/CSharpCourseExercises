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
            return $"{values.Value1} {(char)values.Operator} {values.Value2} = {values.Result}";
        }

        public static Values Add(this Values values)
        {
            values.Result = values.Value1 + values.Value2;
            values.Operator = Operators.Add;
            return values;
        }

        public static Values Subtract(this Values values)
        {
            values.Result = values.Value1 - values.Value2;
            values.Operator = Operators.Subtract;
            return values;
        }

        public static Values Divide(this Values values)
        {
            values.Result = values.Value1 / values.Value2;
            values.Operator = Operators.Divide;
            return values;
        }

        public static Values Multiply(this Values values)
        {
            values.Result = values.Value1 * values.Value2;
            values.Operator = Operators.Multiply;
            return values;
        }
    }
}
