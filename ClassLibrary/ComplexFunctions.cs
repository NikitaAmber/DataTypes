using System;
using System.Text;

namespace ClassLibrary
{

    /// <summary>
    /// Класс содержит функции:
    /// 1. Расчет ИМТ;
    /// 2. Создание массива случайных чисел и его сортировка;
    /// 3. Вычисление средней длинны слов в строке;
    /// </summary>
    public class ComplexFunctions
    {

        /// <summary>
        /// Метод вычисляет индекс массы тела.
        /// </summary>
        /// <param name="weight"> Вес. </param>
        /// <param name="height"> Рост. </param>
        /// <returns> Метод возвращает ИМТ. </returns>
        public string GetBMI(ref double weight, ref double height)
        {
            if (weight<5||height<0.2|| weight > 200 || height > 2.5)
            {
                throw new ArgumentOutOfRangeException("Рост или вес слишком малы или велики");
            }
            return (weight / Math.Pow(height, 2)).ToString();
        }

        /// <summary>
        /// Метод создает и сортирует массив случайных чисел.
        /// </summary>
        /// <param name="size"> Размер создаваемого массива. </param>
        /// <returns> Метод возвращает отсортированный по возрастанию массив. </returns>
        public string GetRandomMassive(ref int size)
        {
            if (size < 1)
            {
                throw new ArgumentOutOfRangeException("Размер массива должен быть больше 0.");
            }
            var random = new Random();
            var massive = new int[size];
            var max = 0;
            var min = 0;
            for (var i = 0; i < size; i++)
            {
                massive[i] = random.Next(-100,100);
                if (max < massive[i])
                {
                    max = massive[i];
                }
                if (min > massive[i])
                {
                    min = massive[i];
                }
            }
            var sortedMassive = new StringBuilder();
            while (min != max+1)
            {
                for (var i = 0; i < size; i++)
                {
                    if (massive[i] == min)
                    {
                        sortedMassive.Append(massive[i]+",");
                    }
                }
                min++;
            }
            return sortedMassive.ToString();

        }

        /// <summary>
        /// Метод возвращает среднюю длинну слова в введенной строке.
        /// </summary>
        /// <param name="text"> Строка введенного теста. </param>
        /// <returns> Возвращает среднюю длинну слов. </returns>
        public string GetAverage(ref string text)
        {
            if (text == "")
            {
                throw new ArgumentOutOfRangeException("Строка не должна быть пустой.");
            }
            string[] words = text.Split(' ');
            var lettersCount = new int[words.Length];
            var sum = 0;
            for (var i = 0; i < words.Length; i++)
            {
                foreach (char a in words[i])
                {
                    if (char.IsLetter(a))
                    {
                        lettersCount[i]++;
                    }
                }
                sum += lettersCount[i];
            }
            return (sum/ lettersCount.Length).ToString();
        }

    }
}
