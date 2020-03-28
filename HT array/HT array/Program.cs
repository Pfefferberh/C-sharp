using System;
using System.Collections.Generic;

//1. Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
//Определить сумму элементов массива, расположенных
//между минимальным и максимальным элементами.
//2. Заполнить массив случайными числами, вывести его на экран.Найти
//самую длинную последовательность чисел, упорядоченную по
//возрастанию.Вывести ее на экран.Если таких последовательностей
//несколько (самых длинных с одинаковой длиной), то вывести их все.

namespace HT_array
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int max = 0;
        //    int min = 0;

        //    int i_max = 0;
        //    int i_min = 0;

        //    int j_max = 0;
        //    int j_min = 0;

        //    int sum = 0;

        //    int[,] arr = new int[5, 5];

        //    Random rand = new Random();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 5; j++)
        //        {
        //            arr[i, j] = rand.Next(-100, 100);
        //            Console.WriteLine(arr[i, j]);

        //            if (arr[i, j] > max)
        //            {
        //                max = arr[i, j];
        //            }
        //            else if (arr[i, j] < min)
        //            {
        //                min = arr[i, j];
        //            }
        //        }

        //        Console.WriteLine("\n");
        //    }
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 5; j++)
        //        {
        //            if (arr[i, j].Equals(min))
        //            {
        //                i_min = i;
        //                j_min = j;
        //            }
        //            else if (arr[i, j].Equals(max))
        //            {
        //                i_max = i;
        //                j_max = j;
        //            }
        //        }
        //    }
        //    Console.WriteLine("Min = " + min);
        //    Console.WriteLine("Max = " + max);
        //    for (int i = i_min; i < 5; i++)
        //    {
        //        for (int j = j_min; j < 5; j++)
        //        {
        //            if (i == i_max && j == j_max)
        //            {
        //                break;
        //            }
        //            else
        //            {
        //                sum = arr[i, j];
        //            }
        //        }

        //    }
        //    Console.WriteLine("Sum = " + sum);
  
        Random rand = new Random();
        int size = 30;
        int[] arr = new int[size];
        List<int> numbers = new List<int>();


        int count = 0;
        int countMax = 0;
        int temp = 0;

            for (int i = 0; i<size; i++) {
                arr[i] = rand.Next(100);
                Console.Write(arr[i] + " ");
            }
    Console.Write("\n");
            for (int i = 0; i<size-1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    count++;
                }

                else if (count > countMax) {
                    countMax = count;
                    count = 0;
                    temp = i;
                }
                else 
                { 
                    count = 0;
                }

            }
            count = temp- countMax;
            for (int i = 0; i < countMax; i++)
            { 
                    numbers.Add(arr[count+1]);
                    count++;                  
            }

            foreach (int was in numbers)
            {
                Console.WriteLine(was);
            }
           
        }
    }
}
    


        
    

