using System;

namespace ClassLibrary1
{
    #region Step 5 - Inside Class Library
    public enum Operators
    {
        Multiply = '*',
        Divide = '/',
        Add = '+',
        Subtract = '-'
    }

    public class Calc
    {
        string _value1, _value2;
        bool Value1Success => double.TryParse(_value1, out _);
        bool Value2Success => double.TryParse(_value2, out _);
        bool EnumSuccess => Enum.IsDefined(typeof(Operators), Operator);

        public double? ParsedValue1 => Value1Success ? (double?)double.Parse(_value1) : null;
        public double? ParsedValue2 => Value2Success ? (double?)double.Parse(_value2) : null;
        public Operators Operator { get; private set; }
        public bool Success => Value1Success && Value2Success && EnumSuccess;
        public double? Result =>
            Success ?
                Operator == Operators.Add ? ParsedValue1 + ParsedValue2 :
                Operator == Operators.Divide ? ParsedValue1 / ParsedValue2 :
                Operator == Operators.Multiply ? ParsedValue1 * ParsedValue2 :
                Operator == Operators.Subtract ? ParsedValue1 - ParsedValue2 :
                null
            : null;
        public string Output => Success ? $"{ParsedValue1} {(char)Operator} {ParsedValue2} = {Result}" : null;

        public Calc(string value1, string value2, Operators operatorIn)
        {
            Operator = operatorIn;
            _value1 = value1;
            _value2 = value2;
        }
    }
    #endregion

}
