using System;
using System.Collections.Generic;
using System.Text;

namespace DataTypes
{
    /// <summary>
    /// Класс содержит функции преобразования введенных в консоль параметров к int и double.
    /// </summary>
    public class InsertFunctions
    {

        /// <summary>
        /// Проверяет введенный параметр с консоли на правильность ввода и преобразует в double.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static double InsertToDouble(string message)
        {
            Console.WriteLine(message);
            bool result = double.TryParse(Console.ReadLine(), out var number);

            if (result == false)
            {
                throw new Exception("Введенный параметр имел неверный формат. Необходимо ввести число.");
            }

            return number;
        }

        /// <summary>
        /// Проверяет введенный параметр с консоли на правильность ввода и преобразует в int.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int InsertToInt(string message)
        {
            Console.WriteLine(message);
            bool result = int.TryParse(Console.ReadLine(), out var number);

            if (result == false)
            {
                throw new Exception("Введенный параметр имел неверный формат. Необходимо ввести число.");
            }

            return number;
        }
    }

}
