using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Вычисление индекса массы тела."+"\n"
                + "2. Сортировка массива случайных чисел." + "\n"
                + "3. Вычисление средней длинны слов в строке текста." + "\n"
                +"Введите номер функции.");
            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Вычисление индекса массы тела." + "\n" + "Введите вес (в кг).");
                        var weight = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите рост (в см).");
                        Console.WriteLine("Ваш ИМТ = " + CallBMI(weight, double.Parse(Console.ReadLine())));
                        Console.WriteLine();
                    }
                    catch
                    {
                        Console.WriteLine("Рост или вес введены некорректно.");
                    }
                    break;
                case "2":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Сортировка массива случайных чисел." + "\n" + "Введите размер массива.");
                        Console.WriteLine("Отсортированный массив: " + "\n" + CallMassive(int.Parse(Console.ReadLine())));
                    }
                    catch
                    {
                        Console.WriteLine("Размер массива введен некорректно.");
                    }
                    break;
                case "3":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("3. Вычисление средней длинны слов в строке текста." + "\n"+"Введите строку текста.");
                        Console.WriteLine("Средняя длинна символов в строке: " + CallAverage(Console.ReadLine()));
                    }
                    catch
                    {
                        Console.WriteLine("Введенная строка пуста");
                    }
                    break;
                default:
                    Console.WriteLine("Не выбрана ни одна из функций.");
                    break;
            }
        }

        /// <summary>
        /// Метод вызывает функцию расчета ИМТ из библиотеки классов.
        /// </summary>
        /// <param name="weight"> Вес. </param>
        /// <param name="height"> Рост. </param>
        /// <returns></returns>
        public static string CallBMI(double weight, double height)
        {
            try
            {
                var functions = new ClassLibrary.ComplexFunctions();
                return functions.GetBMI(weight, height / 100);
            }
            catch (Exception e)
            {
                return "\n"+"Рост или вес слишком малы или велики.";
            }
        }

        /// <summary>
        /// Метод вызывает функцию создания и сортировки случайного массива из библиотеки классов.
        /// </summary>
        /// <param name="size"> Размер массива. </param>
        /// <returns></returns>
        public static string CallMassive(int size)
        {
            try
            {
                var functions = new ClassLibrary.ComplexFunctions();
                return functions.GetRandomMassive(size);
            }
            catch (Exception e)
            {
                return "\n" + "Размер массива должен быть больше 0.";
            }
        }

        /// <summary>
        /// Метод вызывает функцию расчета средней длинны слова из библиотеки классов.
        /// </summary>
        /// <param name="text"> Строка текста. </param>
        /// <returns></returns>
        public static string CallAverage(string text)
        {
            try
            {
                var functions = new ClassLibrary.ComplexFunctions();
                return functions.GetAverage(text);

            }
            catch (Exception e)
            {
                return "\n" + "Cтрока пуста";
            }
        }

    }
}
