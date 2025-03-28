using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuessTheNumber
{
    // Реализация интерфейса IUserInput для консоли
    public class ConsoleUserInput : IUserInput
    {
        // Получить диапазон чисел от пользователя
        public (int min,  int max) GetRange()
        {
            // Получить минимальное и максимальное значения
            var min = GetPositiveInteger("Введите минимальное число диапазона: ");

            var max = GetPositiveInteger("Введите максимальное число диапазона: ");

            // Обеспечить, чтобы min было меньше или равно max
            return (Math.Min(min, max), Math.Max(min, max));
        }

        // Получить попытку угадать число
        public int GetGuess() => GetPositiveInteger("Ваша попытка: ");

        // Получить положительное целое число от пользователя
        public int GetPositiveInteger(string prompt)
        {
            int result;

            // Повторять запрос, пока не будет введено положительное целое число
            do Console.Write(prompt);
            while(!int .TryParse(Console.ReadLine(), out result) || result < 1);

            return result;
        }
    }
}