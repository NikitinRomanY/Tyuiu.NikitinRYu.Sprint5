using tyuiu.cources.programming.interfaces.Sprint5;
using System.Globalization;

namespace Tyuiu.NikitinRYu.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX, CultureInfo.InvariantCulture);

            double y = 1 / (Math.Cos(x) + x) - 4.12 * x;
            y = Math.Round(y, 3);

            return y;
        }
    }
}
