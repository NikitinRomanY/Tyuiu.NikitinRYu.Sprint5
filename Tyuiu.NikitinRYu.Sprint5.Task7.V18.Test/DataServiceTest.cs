using Tyuiu.NikitinRYu.Sprint5.Task7.V18.Lib;

namespace Tyuiu.NikitinRYu.Sprint5.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();

            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V18.txt";

            Assert.IsTrue(File.Exists(inputPath), $"Файл {inputPath} не существует");

            string outputPath = ds.LoadDataAndSave(inputPath);

            Assert.IsTrue(File.Exists(outputPath), $"Выходной файл {outputPath} не создан");

            string resultText = File.ReadAllText(outputPath);

            string expectedText = "Словарнные слова с удвоенной согласнной нн";
            Assert.AreEqual(expectedText, resultText);
        }
    }
}
