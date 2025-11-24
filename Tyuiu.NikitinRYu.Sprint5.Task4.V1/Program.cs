using Tyuiu.NikitinRYu.Sprint5.Task4.V1.Lib;

namespace Tyuiu.NikitinRYu.Sprint5.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть вещественное значение. Прочитать значение      *");
            Console.WriteLine("* из файла и подставить вместо Х в формуле y = 1/(cos(x) + x) - 4.12x     *");
            Console.WriteLine("* Вычислить значение и вернуть полученный результат на консоль.           *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V0.txt";
            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine($"Значение функции y = {result}");

            Console.ReadKey();
        }
    }
}
