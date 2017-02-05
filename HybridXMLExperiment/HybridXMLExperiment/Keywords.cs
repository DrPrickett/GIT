using System;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace HybridXMLExperiment
{
    class KeywordGenerator
    {
        public List<Counter> KeywordGeneration(string InputText, string CommonWordsCSVList, Int32 WordCountLimit)
        {
            InputText = InputText.Replace('\r', ' ').Replace('\n', ' ').Replace('"', ' ').Replace('”', ' ').Replace('“', ' ').Replace("--", " ");
            InputText = InputText.Replace("(", " ").Replace(")", " ").Replace(":", " ").Replace("?", " ").Replace(";", " ").Replace(",", " ").Replace(".", " ");

            string[] CommonWords = CommonWordsCSVList.Split(',');
            foreach (string thisCommonWord in CommonWords)
            {
                InputText = InputText.ToLower().Replace(" " + thisCommonWord.ToLower() + " ", " ");
                InputText = InputText.ToLower().Replace(" " + thisCommonWord.ToLower() + ".", " ");
            }

            string[] allWords = InputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var counts = allWords
                .GroupBy(w => w)
                .Select(g => new Counter
                {
                    Word = g.Key,
                    Count = g.Count()
                })
                .ToList()                
                .OrderByDescending(g => g.Count);

            return counts.Where(s => s.Count > WordCountLimit).ToList();


        }
        public List<Counter> KeywordGeneration(string InputText, string CommonWordsCSVList)
        {
            InputText = InputText.Replace('\r', ' ').Replace('\n', ' ').Replace('"', ' ').Replace('”', ' ').Replace('“', ' ').Replace("--", " ");
            InputText = InputText.Replace("(", " ").Replace(")", " ").Replace(":", " ").Replace("?", " ").Replace(";", " ").Replace(",", " ").Replace(".", " ");

            string[] CommonWords = CommonWordsCSVList.Split(',');
            foreach (string thisCommonWord in CommonWords)
            {
                InputText = InputText.ToLower().Replace(" " + thisCommonWord.ToLower() + " ", " ");
                InputText = InputText.ToLower().Replace(" " + thisCommonWord.ToLower() + ".", " ");
            }

            string[] allWords = InputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var counts = allWords
                .GroupBy(w => w)
                .Select(g => new Counter
                {
                    Word = g.Key,
                    Count = g.Count()
                })
                .ToList()
                .OrderByDescending(g => g.Count);

            return counts.ToList();


        }
        public class Counter
        {
            public string Word { get; set; }
            public int Count { get; set; }
        }
    }
}
