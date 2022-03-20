using System;
using System.Collections.Generic;
using System.Text;

namespace DataTypes
{

    /// <summary>
    /// Класс содержит функцию принудительного сбора мусора.
    /// </summary>
    public class TrashCollector
    {

        /// <summary>
        /// Метод отражает использование памяти до и после принудительного сбора мусора.
        /// </summary>
        public static void TrashCollection()
        {
            Console.WriteLine("Используемая память до сбора мусора: {0}", GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine("Используемая память после сбора мусора: {0}", GC.GetTotalMemory(true));
        }
    }
}
