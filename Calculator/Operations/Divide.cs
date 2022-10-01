using Calculator.Interfaces;

namespace Calculator.Operations
{
    internal class Divide : ICalculatorOperation
    {
        public override string ShowDetails()
        {
            return "Разделить два числа";
        }

        public override double Calculate()
        {
            Console.WriteLine("Введите 2 числа: ");
            double x = InputNumber(), y = InputNumber();
            return y == 0 ? double.NaN : x / y; //посмотри тернарные операторы, это краткий if на одну строку
        }
    }
}
