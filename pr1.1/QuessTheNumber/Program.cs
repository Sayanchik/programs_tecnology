namespace QuessTheNumber
{
    // Точка входа программы
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создать экземпляры классов для ввода, вывода и генерации чисел
            var input = new ConsoleUserInput();
            var output = new ConsoleGameOutput();
            var generator = new RandomNumberGenerator();

            // Создать и запустить игру
            new Game(input, output, generator).Start();
        }
    }
}