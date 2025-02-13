using System;
using System.Collections.Generic;

namespace CSharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приветствие пользователя
            Console.WriteLine("Привет! Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");

            // Пример использования List<T>
            List<string> favoriteFoods = GetFavoriteFoods();

            // Вывод списка любимых блюд
            Console.WriteLine("\nТвои любимые блюда:");
            foreach (string food in favoriteFoods)
            {
                Console.WriteLine($"- {food}");
            }

            // Пример использования switch statement
            DescribeYourTaste(favoriteFoods);

            Console.WriteLine("\nНажмите любую клавишу, чтобы выйти...");
            Console.ReadKey();
        }

        // Метод для получения списка любимых блюд
        static List<string> GetFavoriteFoods()
        {
            List<string> foods = new List<string>();
            Console.WriteLine("\nВведи свои любимые блюда (одно за другим, для завершения введи 'стоп'):");
            string input;
            while ((input = Console.ReadLine()) != "стоп")
            {
                foods.Add(input);
            }
            return foods;
        }

        // Метод, который описывает вкус пользователя на основе его любимых блюд
        static void DescribeYourTaste(List<string> foods)
        {
            if (foods.Count == 0)
            {
                Console.WriteLine("Кажется, у тебя нет любимых блюд! Странно...");
                return;
            }

            Console.WriteLine("\nДавай попробуем описать твой вкус:");

            // Пример switch statement
            switch (foods[0].ToLower())
            {
                case "пицца":
                    Console.WriteLine("Ты любишь классику!");
                    break;
                case "суши":
                    Console.WriteLine("Ты ценишь изысканность и свежесть.");
                    break;
                case "бургер":
                    Console.WriteLine("Ты любишь простую и вкусную еду.");
                    break;
                default:
                    Console.WriteLine("Твой вкус уникален!");
                    break;
            }
        }
    }
}

