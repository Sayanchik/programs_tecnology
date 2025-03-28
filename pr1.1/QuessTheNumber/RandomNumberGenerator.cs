using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuessTheNumber
{
    // Реализация интерфейса INumberGenerator для генерации случайных чисел
    public class RandomNumberGenerator : INumberGenerator
    {
        // Экземпляр класса Random для генерации случайных чисел
        private readonly Random _random = new();

        // Сгенерировать случайное число в диапазоне [min, max]
        public int Generate(int min, int max) => _random.Next(min, max + 1);    
    }
}
