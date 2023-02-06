using System;
using System.IO;
using System.Text;
using Ежедневник;

namespace SimpleNotebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string file_name = "SimpleNotebook.txt";
            string state = null;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine("Запускаем простой ежедневник . .");
            if (System.IO.File.Exists(Convert.ToString(Path.GetFullPath(file_name))) == false)
                Console.WriteLine("Не найден файл SimpleNotebook.txt. . он будет создан автоматически . .");
            Console.WriteLine("Готово . .");
            while (state != "3")
            {
                try
                {
                    Console.WriteLine(" 1 - добавить новую запись  2 - найти запись  3 - выход");
                    state = Console.ReadLine();
                    switch (state)
                    {
                        case "1":
                            pop temp = new pop();
                            Console.WriteLine("Введите день недели: ");
                            temp.Name = Console.ReadLine();
                            Console.WriteLine("Что нужно сделать: ");
                            temp.Wh = Console.ReadLine();
                            Console.WriteLine("Введите время события: ");
                            temp.time = Console.ReadLine();
                            Console.WriteLine("Введите дату события: ");
                            temp.BirthDate = Console.ReadLine();
                            temp.WriteEmployee();
                            break;
                        case "2":
                            string n = null;
                            Console.WriteLine("Введите день недели который нужно вывести: ");
                            n = Console.ReadLine();
                            pop.DisplayEmployee(n);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Работа завершена . . Нажмите клавишу для выхода . .");
            Console.ReadLine();
        }


    }
}