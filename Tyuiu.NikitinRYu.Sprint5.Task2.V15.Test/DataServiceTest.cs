using Tyuiu.NikitinRYu.Sprint5.Task2.V15.Lib;

namespace Tyuiu.NikitinRYu.Sprint5.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                {6, 1, 7},
                {1, 8, 5},
                {6, 6, 4}
            };

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);
            Assert.AreEqual(3, lines.Length);
            Assert.AreEqual("6;0;0", lines[0]);
            Assert.AreEqual("0;8;0", lines[1]);
            Assert.AreEqual("6;6;4", lines[2]);
        }
    }
}
