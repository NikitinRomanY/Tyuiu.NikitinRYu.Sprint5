using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NikitinRYu.Sprint5.Task7.V18.Lib
{
    public class DataService : ISprint5Task7V18
    {
        public string LoadDataAndSave(string path)
        {
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V18.txt");

            string text = File.ReadAllText(path);

            string resultText = text.Replace("н", "нн");

            File.WriteAllText(outputPath, resultText, Encoding.UTF8);

            return outputPath;
        }
    }
}