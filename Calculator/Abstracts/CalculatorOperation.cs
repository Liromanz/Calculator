namespace Calculator.Interfaces
{
    internal abstract class CalculatorOperation
    {
        public abstract string ShowDetails();
        public abstract double Calculate();

        internal double InputNumber()
        {
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Ошибка, попробуйте снова");
            }
            return num;
        }
    }
}
