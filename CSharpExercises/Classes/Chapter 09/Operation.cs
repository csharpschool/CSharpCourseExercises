namespace CSharpExercises.Classes.Chapter_09
{
    public class Operation
    {
        public double Value { get; private set; }
        public Operators Operator { get; private set; } = default;
        public char OperatorValue => (char)Operator;
        
        public Operation(double value, Operators @operator)
        {
            Value = value;
            Operator = @operator;
        }

        public Operation SetOperator(Operators @operator)
        {
            Operator = @operator;
            return this;
        }
        public Operation SetValue(double value)
        {
            Value = value;
            return this;
        }
    }
}
