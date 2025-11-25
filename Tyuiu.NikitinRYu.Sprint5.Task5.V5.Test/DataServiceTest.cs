using Tyuiu.NikitinRYu.Sprint5.Task5.V5.Lib;

namespace Tyuiu.NikitinRYu.Sprint5.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V5.txt";

            Assert.IsTrue(File.Exists(path), $"Файл {path} не существует");

            double result = ds.LoadFromDataFile(path);

            double wait = 30;
            Assert.AreEqual(wait, result);
        }
    }
}
