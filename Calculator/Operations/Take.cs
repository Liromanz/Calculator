using Calculator.Interfaces;

namespace Calculator.Operations
{
    internal class Take : ICalculatorOperation
    {
        public override string ShowDetails()
        {
            return "Вычесть два числа";
        }

        public override double Calculate()
        {
            Console.WriteLine("Введите 2 числа: ");
            double x = InputNumber(), y = InputNumber();
            return x - y; 
        }
    }
}
