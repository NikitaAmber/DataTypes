using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Структура содержит функцию расчета ИМТ.
    /// </summary>
    public struct BmiCalculator
    {

        public double weight;
        public double height;

        /// <summary>
        /// Метод вычисляет индекс массы тела.
        /// </summary>
        /// <returns> Индекс массы тела. </returns>
        public double GetBMI()
        {
            if (weight < 5 || height < 0.2 || weight > 200 || height > 2.5)
            {
                throw new Exception("Рост или вес слишком малы или велики. Введите:" + "\n" + "Вес в диапазоне от 5 до 200 (кг)." + "\n" + "Рост в диапазоне от 20 до 250 (см).");
            }

            return (weight / Math.Pow(height, 2));
        }
    }
}
