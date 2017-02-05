using System;
using System.Linq;

namespace HybridXMLExperiment
{
    class KeywordGenerator
    {
        public List<String> KeywordGeneration(string InputText, string CommonWordsCSVList)
        {
            InputText = InputText.Replace('\r', ' ').Replace('\n', ' ').Replace('"', ' ').Replace('”', ' ').Replace('“', ' ').Replace("--", " ");
            InputText = InputText.Replace("(", " ").Replace(")", " ").Replace(":", " ").Replace("?", " ").Replace(";", " ").Replace(",", " ").Replace(".", " ");

            string[] CommonWords = CommonWordsCSVList.Text.Split(',');
            foreach (string thisCommonWord in CommonWords)
            {
                InputText = InputText.ToLower().Replace(" " + thisCommonWord.ToLower() + " ", " ");
                InputText = InputText.ToLower().Replace(" " + thisCommonWord.ToLower() + ".", " ");
            }

            string[] allWords = InputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var counts = allWords
                .GroupBy(w => w)
                .Select(g => new
                {
                    Word = g.Key,
                    Count = g.Count()
                })
                .ToList()
                .OrderByDescending(g => g.Count);

            return counts.ToList();
        }
    }
}
