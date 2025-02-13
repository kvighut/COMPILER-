using System;
using System.Collections.Generic;

namespace CSharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // ����������� ������������
            Console.WriteLine("������! ��� ���� �����?");
            string name = Console.ReadLine();
            Console.WriteLine($"������, {name}!");

            // ������ ������������� List<T>
            List<string> favoriteFoods = GetFavoriteFoods();

            // ����� ������ ������� ����
            Console.WriteLine("\n���� ������� �����:");
            foreach (string food in favoriteFoods)
            {
                Console.WriteLine($"- {food}");
            }

            // ������ ������������� switch statement
            DescribeYourTaste(favoriteFoods);

            Console.WriteLine("\n������� ����� �������, ����� �����...");
            Console.ReadKey();
        }

        // ����� ��� ��������� ������ ������� ����
        static List<string> GetFavoriteFoods()
        {
            List<string> foods = new List<string>();
            Console.WriteLine("\n����� ���� ������� ����� (���� �� ������, ��� ���������� ����� '����'):");
            string input;
            while ((input = Console.ReadLine()) != "����")
            {
                foods.Add(input);
            }
            return foods;
        }

        // �����, ������� ��������� ���� ������������ �� ������ ��� ������� ����
        static void DescribeYourTaste(List<string> foods)
        {
            if (foods.Count == 0)
            {
                Console.WriteLine("�������, � ���� ��� ������� ����! �������...");
                return;
            }

            Console.WriteLine("\n����� ��������� ������� ���� ����:");

            // ������ switch statement
            switch (foods[0].ToLower())
            {
                case "�����":
                    Console.WriteLine("�� ������ ��������!");
                    break;
                case "����":
                    Console.WriteLine("�� ������ ������������ � ��������.");
                    break;
                case "������":
                    Console.WriteLine("�� ������ ������� � ������� ���.");
                    break;
                default:
                    Console.WriteLine("���� ���� ��������!");
                    break;
            }
        }
    }
}

