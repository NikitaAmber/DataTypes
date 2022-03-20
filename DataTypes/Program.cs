using System;
using System.Text;

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
                    var bmiCalculator = new ClassLibrary.BmiCalculator();
                    Console.Clear();
                    try
                    {
                        bmiCalculator.weight = InsertFunctions.InsertToDouble("Вычисление индекса массы тела." + "\n" + "Введите вес (в кг).");
                        bmiCalculator.height = InsertFunctions.InsertToDouble("Введите рост (в см).") / 100;

                        Console.WriteLine("Ваш ИМТ = " + bmiCalculator.GetBMI());
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "2":
                    var arraySorting = new ClassLibrary.RandomArray();
                    Console.Clear();
                    try
                    {
                        var size = InsertFunctions.InsertToInt("Сортировка массива случайных чисел." + "\n" + "Введите размер массива.");
                        Console.WriteLine("Отсортированный массив: " + "\n"
                            +Output.ArrayOutput(arraySorting.ArraySorting(arraySorting.GetRandomArray(size))));
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "3":
                    var averageValue = new ClassLibrary.WordsAverageValue();
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("3. Вычисление средней длинны слов в строке текста." + "\n" + "Введите строку текста.");
                        Console.WriteLine("Средняя длинна слов в строке: " 
                            + averageValue.GetAverageValue(Console.ReadLine()));
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine(e.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Не выбрана ни одна из функций.");
                    break;
            }
            Console.WriteLine();
            TrashCollector.TrashCollection();
        }
    }
}
