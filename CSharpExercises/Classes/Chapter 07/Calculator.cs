using System.Collections.Generic;
using System.Linq;

namespace CSharpExercises.Classes.Chapter_07
{
    public class Calculator
    {
        public List<Operation> Operations { get; } = new List<Operation>();

        public void AddOperation(Operation operation) => Operations.Add(operation);

        public double Calculate() 
        {
            if (Operations.Count.Equals(0)) return default;
            if (Operations.Count.Equals(1)) return Operations.First().Value;

            Operation result = default;

            foreach (var operation in Operations)
            {
                if (result == default) result = new Operation(operation.Value, operation.Operator);
                else result.Calculate(operation);
            }

            return result.Value;
        }
    }
}
