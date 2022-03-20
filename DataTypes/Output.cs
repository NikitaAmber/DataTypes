using System;
using System.Collections.Generic;
using System.Text;

namespace DataTypes
{
    /// <summary>
    /// Класс содержит функцию вывода массива числе в консоль.
    /// </summary>
    public class Output
    {

        /// <summary>
        /// Метод выводит в консоль 
        /// </summary>
        /// <param name="array"></param>
        public static string ArrayOutput(int[] array)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < array.Length - 2; i++)
            {
                builder.Append(array[i] + ",");
            }
            builder.Append(array[array.Length - 1] + ".");
            return builder.ToString();
        }
    }

}
