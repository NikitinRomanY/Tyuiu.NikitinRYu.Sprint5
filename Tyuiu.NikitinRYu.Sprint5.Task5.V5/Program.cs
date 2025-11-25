using Tyuiu.NikitinRYu.Sprint5.Task5.V5.Lib;

namespace Tyuiu.NikitinRYu.Sprint5.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V5.txt. Найти разницу между *");
            Console.WriteLine("* максимальным и минимальным целыми числами в файле. У вещественных       *");
            Console.WriteLine("* значений округлить до трёх знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V5.txt";

            Console.WriteLine($"Путь к файлу: {path}");
            Console.WriteLine($"Файл существует: {File.Exists(path)}");

            if (!File.Exists(path))
            {
                Console.WriteLine("ОШИБКА: Файл не найден! Проверьте путь и наличие файла.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nСодержимое файла:");
            Console.WriteLine("-----------------");
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("-----------------");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine($"Разница между максимальным и минимальным целыми числами = {result}");

            Console.ReadKey();
        }
    }
}
