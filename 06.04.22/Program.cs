using System;

namespace Name
{
    class ClassName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов массива...");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Введите {++i}-й элемент массива..."); i--;
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Получившийся массив: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.Write("\nМассив в обратном порядке: ");
            for (int i = arr.Length - 1; i >= 0; i--)
                Console.Write($"{arr[i]} ");
            Console.Write("\nСумма четных чисел = ");
            int resArr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    resArr += arr[i];
            }
            Console.WriteLine(resArr);
            Console.Write("Наименьшее число в массиве: ");
            int min = 2000000000;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine(min);
        }
    }
}