using Tyuiu.NikitinRYu.Sprint5.Task6.V9.Lib;

namespace Tyuiu.NikitinRYu.Sprint5.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V9.txt";

            Assert.IsTrue(File.Exists(path), $"Файл {path} не существует");

            int result = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, result);
        }
    }
}
