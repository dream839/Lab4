using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fio = "Федоров Михаил Дмитриечи";
            string group = "ИСП-233";
            DateTime currentDateTime = DateTime.Now;

            Console.WriteLine("Добро пожаловать в программу!");
            Console.WriteLine($"Приветствие: Здравствуйте, {fio}!");
            Console.WriteLine($"Группа: {group}");
            Console.WriteLine($"Текущая дата и время: {currentDateTime}");
            Console.WriteLine();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1 — Показать ФИО");
                Console.WriteLine("2 — Показать группу");
                Console.WriteLine("3 — Показать текущую дату и время");
                Console.WriteLine("4 — Выход");
                Console.Write("Выберите действие (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"ФИО: {fio}");
                        break;
                    case "2":
                        Console.WriteLine($"Группа: {group}");
                        break;
                    case "3":
                        Console.WriteLine($"Текущая дата и время: {DateTime.Now}");
                        break;
                    case "4":
                        Console.WriteLine("Выход из программы...");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор, попробуйте снова.");
                        break;
                }
                Console.WriteLine(); 
            }
        }
    }
}