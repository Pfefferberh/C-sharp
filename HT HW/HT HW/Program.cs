using System;
using System.Collections.Generic;

namespace _09._GC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            //1. Створити узагальнюючий клас, який містить список елементів (List< T >) та реалізує роботу з ним,
            //включаючи сортування. Клас описати за допомогою узагальнюючих алгоритмів Generics. Сортування реалізувати довільним методом 
            //(вибором, бульбашковим тощо).
            List<int> arr = new List<int>();
            arr.Add(5);
            arr.Add(6);
            arr.Add(83);
            arr.Add(12);
            arr.Add(59);
            using (Elements elements = new Elements(arr))
            {
                elements.Sorting();
                foreach (var item in elements)
                {
                    Console.WriteLine(item);
                }
            }
            #endregion
            //2. метод, який дозволяє підрахувати скільки разів кожне слово зустрічається в заданому тексті. 
            //Результат записати в колекцію Dictionary<TKey, TValue>.
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string text = "This is the simple text This This is the simple text This";

            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    dict.Add(words[i], 1);
                }
                catch (ArgumentException)
                {
                    dict[words[i]] += 1;
                }
            }

            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.WriteLine($"Key: {item.Key}\t\t Value: {item.Value}");
            }
        }
    }
}