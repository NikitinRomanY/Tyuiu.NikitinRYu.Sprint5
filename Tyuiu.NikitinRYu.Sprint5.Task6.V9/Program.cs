using System;
using System.IO;
using Tyuiu.NikitinRYu.Sprint5.Task6.V9.Lib;

namespace Tyuiu.NikitinRYu.Sprint5.Task6.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask6V9.txt. Найти количество    *");
            Console.WriteLine("* слов длиной три символа в заданной строке.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V9.txt";

            Console.WriteLine($"Путь к файлу: {path}");
            Console.WriteLine($"Файл существует: {File.Exists(path)}");

            if (!File.Exists(path))
            {
                Console.WriteLine("ОШИБКА: Файл не найден! Проверьте путь и наличие файла.");
                Console.ReadKey();
                return;
            }

            // Выводим содержимое файла
            Console.WriteLine("\nСодержимое файла:");
            Console.WriteLine("-----------------");
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
            Console.WriteLine("-----------------");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Console.WriteLine($"Количество слов длиной 3 символа = {result}");

            Console.ReadKey();
        }
    }
}
