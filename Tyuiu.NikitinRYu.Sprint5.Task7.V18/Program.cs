using Tyuiu.NikitinRYu.Sprint5.Task7.V18.Lib;

namespace Tyuiu.NikitinRYu.Sprint5.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V18.txt. Заменить все       *");
            Console.WriteLine("* буквы 'н' на 'нн'. Полученный результат сохранить в файл                *");
            Console.WriteLine("* OutPutDataFileTask7V18.txt.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V18.txt";

            Console.WriteLine($"Входной файл: {inputPath}");
            Console.WriteLine($"Файл существует: {File.Exists(inputPath)}");

            if (!File.Exists(inputPath))
            {
                Console.WriteLine("ОШИБКА: Входной файл не найден! Проверьте путь и наличие файла.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nИсходный текст:");
            Console.WriteLine("-----------------");
            string originalText = File.ReadAllText(inputPath);
            Console.WriteLine(originalText);
            Console.WriteLine("-----------------");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);

            Console.WriteLine("Текст после замены:");
            Console.WriteLine("-----------------");
            string resultText = File.ReadAllText(outputPath);
            Console.WriteLine(resultText);
            Console.WriteLine("-----------------");

            Console.WriteLine($"\nРезультат сохранён в файл: {outputPath}");

            Console.ReadKey();
        }
    }
}
