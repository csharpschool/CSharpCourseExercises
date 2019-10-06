using System;

namespace CSharpExercises.Classes.Chapter_07
{
    public static class CalculatorExtensions
    {
        public static Operation ChangeOperator(this Operation result, Operators @operator) => result.SetOperator(@operator);
        public static Operation ChangeValue(this Operation result, double value) => result.SetValue(value);
        public static Operation Calculate(this Operation result, Operation operation)
        {
            switch(result.Operator)
            {
                case Operators.Add:
                    result.SetValue(result.Value + operation.Value);
                    break;
                case Operators.Subtract:
                    result.SetValue(result.Value - operation.Value);
                    break;
                case Operators.Divide:
                    result.SetValue(result.Value / operation.Value);
                    break;
                case Operators.Multiply:
                    result.SetValue(result.Value * operation.Value);
                    break;
                case Operators.Equals: return result;
                default: throw new ArgumentException("Opertion does not exist.", nameof(operation));
            };

            return result.SetOperator(operation.Operator);
        }

        //public static Operation Calculate(this Operation result, Operation operation) =>
        //    result.Operator switch
        //    {
        //        Operators.Add => result.ChangeValue(result.Value + operation.Value).ChangeOperator(operation.Operator),
        //        Operators.Subtract => result.ChangeValue(result.Value - operation.Value).ChangeOperator(operation.Operator),
        //        Operators.Divide => result.ChangeValue(result.Value / operation.Value).ChangeOperator(operation.Operator),
        //        Operators.Multiply => result.ChangeValue(result.Value * operation.Value).ChangeOperator(operation.Operator),
        //        Operators.Equals => result,
        //        _ => throw new ArgumentException("Opertion does not exist.", nameof(operation)),
        //    };

    }
}
