using Calculator.Interfaces;

namespace Calculator.Operations
{
    internal class Multiply : ICalculatorOperation
    {
        public override string ShowDetails()
        {
            return "Перемножить два числа";
        }

        public override double Calculate()
        {
            Console.WriteLine("Введите 2 числа: ");
            double x = InputNumber(), y = InputNumber();
            return x * y;
        }
    }
}
