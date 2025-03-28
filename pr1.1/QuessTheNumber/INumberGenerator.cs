using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuessTheNumber
{
    // Интерфейс для генерации случайных чисел
    public interface INumberGenerator
    {
        int Generate(int min, int max);
    }
}
