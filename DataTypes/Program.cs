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
                        var height = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ваш ИМТ = " + CallFunctions.CallBMI(ref weight, ref height));
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
                        var size = int.Parse(Console.ReadLine());
                        Console.WriteLine("Отсортированный массив: " + "\n" + CallFunctions.CallMassive(ref size));
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
                        var text = Console.ReadLine();
                        string result;
                        //Console.WriteLine("Средняя длинна символов в строке: " + CallFunctions.CallAverage(text,out result));
                        CallFunctions.CallAverage(ref text, out result);
                        Console.WriteLine(result);
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
            CallFunctions.TrashCollection();
        }

        
    }
    public struct CallFunctions
    {
        /// <summary>
        /// Метод вызывает функцию расчета ИМТ из библиотеки классов.
        /// </summary>
        /// <param name="weight"> Вес. </param>
        /// <param name="height"> Рост. </param>
        /// <returns></returns>
        public static string CallBMI(ref double weight, ref double height)
        {
            try
            {
                var functions = new ClassLibrary.ComplexFunctions();
                height = height / 100;
                return functions.GetBMI(ref weight,ref height);
            }
            catch (Exception e)
            {
                return "\n" + "Рост или вес слишком малы или велики.";
            }
        }

        /// <summary>
        /// Метод вызывает функцию создания и сортировки случайного массива из библиотеки классов.
        /// </summary>
        /// <param name="size"> Размер массива. </param>
        /// <returns></returns>
        public static string CallMassive(ref int size)
        {
            try
            {
                var functions = new ClassLibrary.ComplexFunctions();
                return functions.GetRandomMassive(ref size);
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
        public static void CallAverage(ref string text,out string result)
        {
            try
            {
                var functions = new ClassLibrary.ComplexFunctions();
                result=functions.GetAverage(ref text);

            }
            catch (Exception e)
            {
                result= "\n" + "Cтрока пуста";
            }
        }
        public static void TrashCollection()
        {
            Console.WriteLine("Используемая память до сбора мусора: {0}", GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("Используемая память после сбора мусора: {0}", GC.GetTotalMemory(true));
        }
    }
}
