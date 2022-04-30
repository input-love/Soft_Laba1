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
            int checkExit;
            do
            {
                // Сколько чисел введет пользователь
                int count = GetCount();
                // Заполнение числами массива, для дальнейшей конвертации
                int[] array = CreateArray(count);
                // Используемая система счисления
                int numberSystem = GetNumberСalcSystem();

                // Отлавливание ошибки
                try
                {
                    // Обращение к фабрике, присваивание возращаемого значения
                    NumberSystem = factory.createSystem(numberSystem);
                }
                catch (Exception ex)
                {
                    // Вывод ошибки
                    Console.WriteLine(ex.Message);
                    // Выход из программы
                    return;
                }

                // Конвертация массива данных
                string[] convertArray = ConvertArray(array, numberSystem);

                // Вывод результируещего массива
                PrintArray(array, convertArray);

                // Переменная для завершения работы консоли
                checkExit = GetCheckExit();

            } while (checkExit != 2); // Проверка числа
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

        // Запрос, завершение работы консоли
        private int GetCheckExit()
        {
            PrintExit();
            int check = Convert.ToInt32(Console.ReadLine());
            return check;
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

        // Меню, завершения работы консоли
        private void PrintExit()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Завершить программу?:");
            Console.WriteLine("1. Нет, продолжить работу");
            Console.WriteLine("2. Да, завершить работу");
            Console.WriteLine("-------------------------------------------");
        }
        //----------------------------------------------------------------

        // Переменные
        //----------------------------------------------------------------
        INumberSystem NumberSystem;
        Factory factory = new Factory();
        //----------------------------------------------------------------
    }
}