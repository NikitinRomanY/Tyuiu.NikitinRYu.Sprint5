using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NikitinRYu.Sprint5.Task5.V5.Lib
{
    public class DataService : ISprint5Task5V5
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int min = int.MaxValue;
            int max = int.MinValue;
            bool foundIntegers = false;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] numbers = line.Split(' ');

                foreach (string numberStr in numbers)
                {
                    if (int.TryParse(numberStr.Trim(), out int number))
                    {
                        foundIntegers = true;
                        if (number < min) min = number;
                        if (number > max) max = number;
                    }
                }
            }

            if (!foundIntegers)
            {
                throw new Exception("В файле не найдено целых чисел");
            }

            double result = max - min;
            return Math.Round(result, 3);
        }
    }
}
