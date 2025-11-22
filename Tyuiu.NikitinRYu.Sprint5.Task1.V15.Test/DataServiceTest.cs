using Tyuiu.NikitinRYu.Sprint5.Task1.V15.Lib;

namespace Tyuiu.NikitinRYu.Sprint5.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);
            Assert.AreEqual(13, lines.Length);

            string lineForX0 = lines[7];
            Assert.IsTrue(lineForX0.Contains("0\t"));
        }
    }
}
