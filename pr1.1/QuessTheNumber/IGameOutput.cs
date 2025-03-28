using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuessTheNumber
{
    // Интерфейс для вывода сообщений игры
    public interface IGameOutput
    {
        // Вывести приветствие
        void ShowWelcome();

        // Вывести результат попытки угадать число
        void ShowGuessResult(int difference);

        // Вывести сообщение о победе
        void ShowWin(int attempts);

        // Вывести сообщение о необходимости повторить ввод
        void ShowRetryPrompt();

    }
}
