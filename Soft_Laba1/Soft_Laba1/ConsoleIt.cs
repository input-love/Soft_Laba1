using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft_Laba1
{
    internal class ConsoleIt
    {
        public void StartConsole()
        {
            int count = GetCount();
            int[] array = CreateArray(count);
            int numberSystem = GetNumberСalcSystem();

            CreateFactory(numberSystem);
            
            string[] convertArray = ConvertArray(array, numberSystem);

            PrintArray(array, convertArray);
        }

        private int GetCount()
        {
            Console.WriteLine("Сколько чисел вы хотите ввести?:");
            int count = Convert.ToInt32(Console.ReadLine());
            return count;
        }

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

        private int GetNumberСalcSystem()
        {
            Console.WriteLine("Ввидете число, систему счисления которого хотите использовать:");
            int nymberSystem = Convert.ToInt32(Console.ReadLine());
            return nymberSystem;
        }

        private void CreateFactory(int numberSystem)
        {
            Factory factory = new Factory();
            NumberSystem = factory.createSystem(numberSystem);
        }

        private string[] ConvertArray(int[] array, int numberSystem)
        {
            string[] convertArray = new string[array.Length];
            
            for(int i = 0; i < array.Length; ++i)
            {
                convertArray[i] = NumberSystem.Convert(array[i], numberSystem);
            }

            return convertArray;
        }

        private void PrintArray(int[] array, string[] convertArray)
        {
            Console.WriteLine("Выходные данные:");

            for(int i = 0; i < convertArray.Length; ++i)
            {
                Console.WriteLine(array[i] + " : " + convertArray[i]);
            }
        }

        NumberSystem NumberSystem;
    }
}