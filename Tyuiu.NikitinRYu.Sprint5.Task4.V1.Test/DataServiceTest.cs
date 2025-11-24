using Tyuiu.NikitinRYu.Sprint5.Task4.V1.Lib;

namespace Tyuiu.NikitinRYu.Sprint5.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask4V1.txt";

            double x = 1.05;
            double wait = 1 / (Math.Cos(x) + x) - 4.12 * x;
            wait = Math.Round(wait, 3);

            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
