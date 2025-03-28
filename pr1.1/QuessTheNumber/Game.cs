using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuessTheNumber
{
    // Класс, управляющий игровым процессом
    public class Game
    {
        // Ввод данных от пользователя
        private readonly IUserInput _input;

        // Вывод сообщений игры
        private readonly IGameOutput _output;

        // Генератор случайных чисел
        private readonly INumberGenerator _generator;

        // Конструктор для внедрения зависимостей
        public Game(IUserInput input, IGameOutput output, INumberGenerator generator)
        {
            _input = input;
            _output = output;
            _generator = generator;
        }

        // Запустить игру
        public void Start()
        {
            // Вывести приветствие
            _output.ShowWelcome();

            // Получить диапазон чисел от пользователя
            var (min, max) = _input.GetRange();

            // Сгенерировать случайное число в диапазоне
            var target = _generator.Generate(min, max);

            // Счетчик попыток
            var attempts = 0;

            // Игровой цикл
            while (true)
            {
                attempts++;

                // Получить попытку угадать число
                var guess = _input.GetGuess();

                // Рассчитать разницу между попыткой и загаданным числом
                var difference = guess.CompareTo(target);

                // Вывести результат попытки
                _output.ShowGuessResult(difference);

                // Если угадано, выйти из цикла
                if (difference == 0) break;
            }

            // Вывести сообщение о победе
            _output.ShowWin(attempts);
        }
    }
}