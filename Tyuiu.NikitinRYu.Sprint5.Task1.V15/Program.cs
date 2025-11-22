using Tyuiu.NikitinRYu.Sprint5.Task1.V15.Lib;

namespace Tyuiu.NikitinRYu.Sprint5.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = cos(x)/(x - 0,4) + sin(x) * 8x + 2. Произвести      *");
            Console.WriteLine("* табулирование на диапазоне [-5; 5] с шагом 1. При делении на ноль       *");
            Console.WriteLine("* вернуть 0. Результат сохранить в файл OutPutFileTask1.txt и вывести     *");
            Console.WriteLine("* в таблицу. Округлить до двух знаков.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Стартовое значение x = {startValue}");
            Console.WriteLine($"Конечное значение x = {stopValue}");
            Console.WriteLine($"Шаг = 1");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("┌────────────────┐");
            Console.WriteLine("   x   │   F(x)   ");
            Console.WriteLine("├────────────────┤");

            string[] lines = File.ReadAllLines(path);
            for (int i = 2; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('\t');
                Console.WriteLine($"│ {parts[0],3}  │  {parts[1],6} │");
            }
            Console.WriteLine("└────────────────┘");

            Console.WriteLine($"\nДанные сохранены в файл: {path}");
            Console.ReadKey();
        }
    }
}
