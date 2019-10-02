using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация массива и его заполнение
            Console.WriteLine("Write size of array: ");
            int count = 0;
            do
            {
                int.TryParse(Console.ReadLine(), out count);
                if (count > 10000)
                {
                    Console.WriteLine("Array size must be less than 10000 or equal. Try again");
                }
                else
                {
                    break;
                }
            } while (true);
            int[] array = new int[count];
            Console.WriteLine("Fill this array: ");
            for (int index = 0; index < count; index++)
            {
                int.TryParse(Console.ReadLine(), out array[index]);
            }
            Console.WriteLine("Array filling finished");

            // Обработка массива по заданию
            int numbersBeginningFrom1 = 0;
            foreach (int number in array) {
                string numberInString = number.ToString();
                char digitToCompare = char.Parse("1");
                if (numberInString[0].Equals(digitToCompare))
                {
                    numbersBeginningFrom1++;
                }
                if (numbersBeginningFrom1 > 1)
                {
                    Sort(array);
                    break;
                }
            }

            // Вывод массива. Если произошла сортировка - вывод отсортированного массива
            Console.WriteLine("Array:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
        }

        // Используется сортировка вставкой
        static void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int val = array[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.WriteLine("Sorting done");
        }
    }
}
