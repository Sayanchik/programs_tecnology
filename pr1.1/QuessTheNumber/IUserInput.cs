using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuessTheNumber
{
    // Интерфейс для ввода данных от пользователя
    public interface IUserInput
    {
        // Получить попытку угадать число
        int GetGuess();

        // Получить диапазон чисел от пользователя
        (int min, int max) GetRange();

        // Получить положительное целое число от пользователя
        int GetPositiveInteger(string prompt);

    }
}
    