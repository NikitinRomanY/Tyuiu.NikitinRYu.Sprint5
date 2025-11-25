using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NikitinRYu.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string cleanedText = Regex.Replace(text, @"[^\w\s]", " ");

            string[] words = cleanedText.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            foreach (string word in words)
            {
                if (word.Length == 3)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
