using Calculator.Extensions;
using Calculator.Interfaces;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var types = GetAllClassesByType(typeof(CalculatorOperation));
            byte selectedOperation;
            do
            {
                ShowMenu(types);
                while (!byte.TryParse(Console.ReadLine(), out selectedOperation))
                {
                    Console.WriteLine("Вы ввели неверное число. Попробуйте еще раз");
                    ShowMenu(types);
                }

                if (selectedOperation != types.Length) //этот if мне не очень нравится, так как точно такое же условие у меня стоит в цикле
                {
                    var result = types.CalculateChosenOperation(selectedOperation);
                    Console.WriteLine($"Результат - {result}");
                }

            } while (selectedOperation != types.Length);
        }

        static void ShowMenu(Type[] operations)
        {
            Console.WriteLine("Выберите операцию: ");
            int i = 0;
            while (i < operations.Count())
            {
                //тут я нахожу метод, создаю экземпляр класса, в котором этот метод лежит и запускаю его через Invoke
                var result = operations[i].GetMethod("ShowDetails")?
                    .Invoke(Activator.CreateInstance(operations[i]), null);
                Console.WriteLine($"{i} - {result}");
                i++;
            }
            Console.WriteLine($"{i} - Выйти из программы");
        }


        private static Type[] GetAllClassesByType(Type type)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract && !p.IsInterface).ToArray();
        }
    }
}