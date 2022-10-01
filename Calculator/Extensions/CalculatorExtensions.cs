namespace Calculator.Extensions
{
    public static class CalculatorExtensions
    {

        // а еще я обожаю методы расширения! мы их будем в самом конце полугодия проходить
        // но если тебе интересно, можешь посмотреть сейчас что это
        public static double CalculateChosenOperation(this Type[] types, int chosed)
        {
            var result = types[chosed].GetMethod("Calculate")?
                    .Invoke(Activator.CreateInstance(types[chosed]), null);
            return result != null ? (double)result : double.NaN;
        }
    }
}
