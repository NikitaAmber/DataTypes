using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Класс содержит функцию вычисления средней длинны слов в строке.
    /// </summary>
    public class WordsAverageValue
    {

        /// <summary>
        /// Производит вычисление средней длинны слов в строке.
        /// </summary>
        /// <param name="text"> Cтрока текста. </param>
        /// <returns> Средняя длинна слов в строке. </returns>
        public double GetAverageValue(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new Exception("Строка не должна быть пустой.");
            }

            var wordsArray = text.Split(' ');
            var sum = 0;
            for (var i = 0; i < wordsArray.Length; i++)
            {
                foreach (char a in wordsArray[i])
                {
                    if (char.IsLetter(a))
                    {
                        sum++;
                    }
                }
            }
            return sum / wordsArray.Length;
        }

    }
}
