using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NikitinRYu.Sprint5.Task3.V16.Lib
{
    public class DataService : ISprint5Task3V16
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double numerator = 2 * Math.Pow(x, 2) - 1;
            double denominator = Math.Sqrt(Math.Pow(x, 2) - 2);
            double y = numerator / denominator;
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            return path;
        }
    }
}
