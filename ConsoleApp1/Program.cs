using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    #region Step 2 - Enum
    //enum Operators
    //{
    //    Multiply = '*',
    //    Divide = '/',
    //    Add = '+',
    //    Subtract = '-'
    //}
    #endregion

    #region Step 3 - Variables
    //class Calc
    //{
    //    public double? result = null;
    //    public string output = null;
    //    public bool success = false;

    //    readonly double _parsedValue1, _parsedValue2;
    //    readonly Operators _selectedOperator;

    //    public Calc(string value1, string value2, Operators operatorIn)
    //    {
    //        _selectedOperator = operatorIn;
    //        var value1Success = double.TryParse(value1, out _parsedValue1);
    //        var value2Success = double.TryParse(value2, out _parsedValue2);
    //        var enumSuccess = Enum.IsDefined(typeof(Operators), _selectedOperator);
    //        success = value1Success && value2Success && enumSuccess;

    //        if (success)
    //        {
    //            if (_selectedOperator == Operators.Add)
    //                result = _parsedValue1 + _parsedValue2;

    //            if (_selectedOperator == Operators.Divide)
    //                result = _parsedValue1 / _parsedValue2;

    //            if (_selectedOperator == Operators.Multiply)
    //                result = _parsedValue1 * _parsedValue2;

    //            if (_selectedOperator == Operators.Subtract)
    //                result = _parsedValue1 - _parsedValue2;

    //            output = $"{_parsedValue1} {(char)_selectedOperator} {_parsedValue2} = {result}";
    //        }
    //    }
    //}
    #endregion

    #region Step 4 - Properties
    //class Calc
    //{
    //    string _value1, _value2;
    //    bool Value1Success => double.TryParse(_value1, out _);
    //    bool Value2Success => double.TryParse(_value2, out _);
    //    bool EnumSuccess => Enum.IsDefined(typeof(Operators), Operator);

    //    public double? ParsedValue1 => Value1Success ? (double?)double.Parse(_value1) : null;
    //    public double? ParsedValue2 => Value2Success ? (double?)double.Parse(_value2) : null;
    //    public Operators Operator { get; private set; }
    //    public bool Success => Value1Success && Value2Success && EnumSuccess;
    //    public double? Result => 
    //        Success ?
    //            Operator == Operators.Add ? ParsedValue1 + ParsedValue2 :
    //            Operator == Operators.Divide ? ParsedValue1 / ParsedValue2 :
    //            Operator == Operators.Multiply ? ParsedValue1 * ParsedValue2 :
    //            Operator == Operators.Subtract ? ParsedValue1 - ParsedValue2 : 
    //            null
    //        : null;
    //    public string Output => Success ? $"{ParsedValue1} {(char)Operator} {ParsedValue2} = {Result}" : null;

    //    public Calc(string value1, string value2, Operators operatorIn)
    //    {
    //        Operator = operatorIn;
    //        _value1 = value1;
    //        _value2 = value2;
    //    }
    //}
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region Step 1 - No Class
            //Console.WriteLine("Calculator");
            //Console.WriteLine("Enter Value 1");
            //string value1 = Console.ReadLine();
            //Console.WriteLine("Enter Value 2");
            //string value2 = Console.ReadLine();

            //bool success1 = double.TryParse(value1, out double parsedValue1);
            //bool success2 = double.TryParse(value2, out double parsedValue2);

            //if(success1 && success2)
            //{
            //    Console.WriteLine($"Values {parsedValue1}, {parsedValue2} can be converted.");
            //}
            #endregion

            #region Step 2 - No Class & Enum
            //Console.WriteLine("Calculator");
            //Console.WriteLine("Enter Value 1");
            //string value1 = Console.ReadLine();
            //Console.WriteLine("Enter Value 2");
            //string value2 = Console.ReadLine();
            //Console.WriteLine("* (multiply), / (divide), + (add), - (subtract)");
            //string operatorIn = Console.ReadLine();

            //if(operatorIn.Length != 1)
            //{
            //    Console.WriteLine("Could not calculate the given values.");
            //    return;
            //}

            //char operatorSymbol = operatorIn[0];
            //bool value1Success = double.TryParse(value1, out double parsedValue1);
            //bool value2Success = double.TryParse(value2, out double parsedValue2);
            //Operators selectedOperator = (Operators)Enum.ToObject(typeof(Operators), operatorSymbol);
            //bool enumSuccess = Enum.IsDefined(typeof(Operators), selectedOperator);

            //if (value1Success && value2Success && enumSuccess)
            //{
            //    double result = default;

            //    if (selectedOperator == Operators.Add)
            //        result = parsedValue1 + parsedValue2;

            //    if (selectedOperator == Operators.Divide)
            //        result = parsedValue1 / parsedValue2;

            //    if (selectedOperator == Operators.Multiply)
            //        result = parsedValue1 * parsedValue2;

            //    if (selectedOperator == Operators.Subtract)
            //        result = parsedValue1 - parsedValue2;

            //    Console.WriteLine($"{parsedValue1} {(char)selectedOperator} {parsedValue2} = {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Could not calculate the given values.");
            //}
            #endregion

            #region Step 3 - Class With Variables
            //Console.WriteLine("Calculator");
            //Console.WriteLine("Enter Value 1");
            //string value1 = Console.ReadLine();
            //Console.WriteLine("Enter Value 2");
            //string value2 = Console.ReadLine();
            //Console.WriteLine("* (multiply), / (divide), + (add), - (subtract)");
            //string operatorIn = Console.ReadLine();
            //char operatorSymbol = operatorIn[0];
            //Operators selectedOperator = (Operators)Enum.ToObject(typeof(Operators), operatorSymbol);

            //var calculator = new Calc(value1, value2, selectedOperator);

            //if (calculator.success)
            //{
            //    Console.WriteLine($"Result: {calculator.result}");
            //    Console.WriteLine(calculator.output);

            //    // Data isn't encapsulated
            //    Console.WriteLine("\n--- After varaible values are changed ---");
            //    calculator.result = 20;
            //    Console.WriteLine($"Result: {calculator.result}");
            //    calculator.output = "Changed output";
            //    Console.WriteLine(calculator.output);
            //}
            //else
            //    Console.WriteLine("Could not calculate the given values.");
            #endregion

            #region Step 4 - Class With Properties
            //Console.WriteLine("Calculator");
            //Console.WriteLine("Enter Value 1");
            //string value1 = Console.ReadLine();
            //Console.WriteLine("Enter Value 2");
            //string value2 = Console.ReadLine();
            //Console.WriteLine("* (multiply), / (divide), + (add), - (subtract)");
            //string operatorIn = Console.ReadLine();
            //char operatorSymbol = operatorIn[0];
            //Operators selectedOperator = (Operators)Enum.ToObject(typeof(Operators), operatorSymbol);

            //var calculator = new Calc(value1, value2, selectedOperator);

            //if (calculator.Success)
            //{
            //    Console.WriteLine($"Result: {calculator.Result}");
            //    Console.WriteLine($"Parsed Value1: {calculator.ParsedValue1}");
            //    Console.WriteLine($"Parsed Value2: {calculator.ParsedValue2}");
            //    Console.WriteLine($"Operator: {(char)calculator.Operator} ({calculator.Operator})");
            //    Console.WriteLine(calculator.Output);
            //}
            //else
            //    Console.WriteLine("Could not calculate the given values.");
            #endregion

            #region Step 5 - Inside Class Library
            Console.WriteLine("Calculator");
            Console.WriteLine("Enter Value 1");
            string value1 = Console.ReadLine();
            Console.WriteLine("Enter Value 2");
            string value2 = Console.ReadLine();
            Console.WriteLine("* (multiply), / (divide), + (add), - (subtract)");
            string operatorIn = Console.ReadLine();
            char operatorSymbol = operatorIn[0];
            Operators selectedOperator = (Operators)Enum.ToObject(typeof(Operators), operatorSymbol);

            var calculator = new Calc(value1, value2, selectedOperator);

            if (calculator.Success)
            {
                Console.WriteLine($"Result: {calculator.Result}");
                Console.WriteLine($"Parsed Value1: {calculator.ParsedValue1}");
                Console.WriteLine($"Parsed Value2: {calculator.ParsedValue2}");
                Console.WriteLine($"Operator: {(char)calculator.Operator} ({calculator.Operator})");
                Console.WriteLine(calculator.Output);
            }
            else
                Console.WriteLine("Could not calculate the given values.");
            #endregion

        }
    }
}
