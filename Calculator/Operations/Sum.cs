using Calculator.Interfaces;

namespace Calculator.Operations
{
    internal class Sum : CalculatorOperation
    {
        public override string ShowDetails()
        {
            return "Сложить два числа";
        }

        public override double Calculate()
        {
            Console.WriteLine("Введите 2 числа: ");
            double x = InputNumber(), y = InputNumber();
            return x + y;
        }
    }
}
