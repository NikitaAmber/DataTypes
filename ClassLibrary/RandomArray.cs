using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Класс содержит функции создания и сортировки массива случайных чисел.
    /// </summary>
    public class RandomArray
    {

        /// <summary>
        /// Метод создает и заполняет массив, запрашиваемого размера, случайными числами.
        /// </summary>
        /// <param name="size"> Размер массива. </param>
        /// <returns> Массив заполненный случайными числами </returns>
        public int[] GetRandomArray(int size)
        {
            if (size < 1)
            {
                throw new Exception("Размер массива должен быть больше 0.");
            }

            var random = new Random();
            var mainArray = new int[size];
            for (var i = 0; i < size; i++)
            {
                mainArray[i] = random.Next(-100, 100);

            }
            return mainArray;
        }

        /// <summary>
        /// Метод производит сортировку массива (по возрастанию).
        /// </summary>
        /// <param name="array"> Массив чисел. </param>
        /// <returns> Отсортированный (по возрастанию) массив чисел. </returns>
        public int[] ArraySorting(int[] array)
        {
            var temp = 0;
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
