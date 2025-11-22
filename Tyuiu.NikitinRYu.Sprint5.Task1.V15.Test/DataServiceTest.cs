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
            Assert.AreEqual(11, lines.Length);

            Assert.AreEqual("-36,41", lines[0]);
            Assert.AreEqual("-0,5", lines[5]);
            Assert.AreEqual("-36,3", lines[10]);
        }
    }
}
