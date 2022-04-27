using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba1
{
    internal class ConsoleIt
    {
            // Запуск консоли
        //----------------------------------------------------------------
        public void StartConsole()
        {
            int count = GetCount();
            int[] array = CreateArray(count);
            int numberSystem = GetNumberСalcSystem();

            CreateFactory(numberSystem);
            
            string[] convertArray = ConvertArray(array, numberSystem);

            PrintArray(array, convertArray);
        }
        //----------------------------------------------------------------

            // Взаимодейсвие с пользователем
        //----------------------------------------------------------------
        // Запрос, сколько чисел пользователь хочет перевести в другую систему счисления
        private int GetCount()
        {
            Console.WriteLine("Сколько чисел вы хотите ввести?:");
            int count = Convert.ToInt32(Console.ReadLine());
            return count;
        }

        // Запрос, занесение массива данных для дальнейшей обработки
        private int[] CreateArray(int count)
        {
            Console.WriteLine("Введите числа:");

            int[] array = new int[count];
            for(int i = 0; i < count; ++i)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }

        // Запрос, в какую систему счисления перевести массив данных
        private int GetNumberСalcSystem()
        {
            Console.WriteLine("В какую систему счисления перевести?:");
            int nymberSystem = Convert.ToInt32(Console.ReadLine());
            return nymberSystem;
        }
        //----------------------------------------------------------------

            // Обращение к фабрике 
        //----------------------------------------------------------------
        private void CreateFactory(int numberSystem)
        {
            NumberSystem = Factory.createSystem(numberSystem);
        }
        //----------------------------------------------------------------

            // Обработка массива данных (перевод в другую систему счисления)
        //----------------------------------------------------------------
        private string[] ConvertArray(int[] array, int numberSystem)
        {
            string[] convertArray = new string[array.Length];
            
            for(int i = 0; i < array.Length; ++i)
            {
                convertArray[i] = NumberSystem.Convert(array[i], numberSystem);
            }

            return convertArray;
        }
        //----------------------------------------------------------------

            // Вывод в консоль
        //----------------------------------------------------------------
        private void PrintArray(int[] array, string[] convertArray)
        {
            Console.WriteLine("Выходные данные:");

            for(int i = 0; i < convertArray.Length; ++i)
            {
                Console.WriteLine(array[i] + " : " + convertArray[i]);
            }
        }
        //----------------------------------------------------------------

            // Переменные
        //----------------------------------------------------------------
        INumberSystem NumberSystem;
        //----------------------------------------------------------------
    }
}