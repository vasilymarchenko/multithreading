using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ParallelDemo
{
    public class DictChecker
    {
        HashSet<string> _wordLookup;
        string[] _wordsToTest;
        struct IndexedWord { public string Word; public int Index; }

        public DictChecker()
        {
            _wordLookup = LoadDictionary();
            _wordsToTest = CreateDoc();
        }

        protected HashSet<string> LoadDictionary()
        {
            if (!File.Exists("WordLookup.txt"))    // Содержит порядка 150,000 слов
                new WebClient().DownloadFile(
                  "http://www.albahari.com/ispell/allwords.txt", "WordLookup.txt");

            return new HashSet<string>(
              File.ReadAllLines("WordLookup.txt"),
              StringComparer.InvariantCultureIgnoreCase);
        }

        protected string[] CreateDoc()
        {
            var random = new Random();
            string[] wordList = _wordLookup.ToArray();

            string[] wordsToTest = Enumerable.Range(0, 1000000)
              .Select(i => wordList[random.Next(0, wordList.Length)])
              .ToArray();

            wordsToTest[12345] = "woozsh";     // Делаем несколько 
            wordsToTest[23456] = "wubsie";     // ошибок.

            return wordsToTest;
        }

        public void Check()
        {
            var query = _wordsToTest
              .AsParallel()
              //.WithDegreeOfParallelism(6)
              .Select((word, index) => new IndexedWord { Word = word, Index = index })
              .Where(iword => !_wordLookup.Contains(iword.Word))
              .OrderBy(iword => iword.Index);

            var result = query.ToArray<IndexedWord>();

            /*
            var query2 = _wordsToTest
              .AsParallel()
              .Select((word, index) => new { Word = word, Index = index }) //Anonim type
              .Where(iword => !_wordLookup.Contains(iword.Word))
              .OrderBy(iword => iword.Index);
              */
        }
    }
}
