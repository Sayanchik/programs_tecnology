using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuessTheNumber
{
    // Реализация интерфейса IGameOutput для консоли
    public class ConsoleGameOutput : IGameOutput
    {
        // Вывести приветствие
        public void ShowWelcome() => Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");

        // Вывести результат попытки угадать число
        public void ShowGuessResult(int difference)
        {
            Console.WriteLine(difference switch
            {
                // В зависимости от разницы выводить подсказку
                < 0 => "загаданное число больше",
                > 0 => "загаданное число меньше",
                _ => "Поздравляем! Вы угадали!"
            });
        }

        // Вывести сообщение о победе
        public void ShowWin(int attempts) =>
            Console.WriteLine($"Победа! Количество попыток: {attempts}");

        // Вывести сообщение о необходимости повторить ввод
        public void ShowRetryPrompt() => Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
    }
}
