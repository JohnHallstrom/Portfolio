using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace CSharpLaborationFourLibrary
{
    public class WordList
    {
        public static readonly string LocalApplicationDirectory = (
            $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\" +
            $"WordList\\");

        private List<Word> words = new List<Word>();

        private Random random = new Random();
        public string Name { get; }
        public string[] Languages { get; }
        
        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }
        public static string[] GetLists()
        {
            string[] lists = Directory.GetFiles(LocalApplicationDirectory);

            for (int i = 0; i < lists.Length; i++)
            {
                lists[i] = Path.GetFileNameWithoutExtension(lists[i]);
            }

            return lists;
        }
        public static WordList LoadList(string name)
        {
            if (File.Exists($"{LocalApplicationDirectory}{name}.dat"))
            {
                string[] linesOfText = File.ReadAllLines($"{LocalApplicationDirectory}{name}.dat");

                string[] languages = linesOfText[0].TrimEnd(';').Split(';');

                WordList bufferWordList = new WordList(name, languages);

                for (int i = 1; i < linesOfText.Length; i++)
                {
                    string[] wordSplits = linesOfText[i].TrimEnd(';').Split(';');

                    bufferWordList.words.Add(new Word(wordSplits));
                }

                return bufferWordList;
            }
            else
            {
                throw new IOException("File not found.");
            }
        }
        public void Save()
        {
            StringBuilder stringBuiler = new StringBuilder();

            foreach (string language in Languages)
            {
                stringBuiler.Append($"{language};");
            }

            foreach (Word item in words)
            {
                stringBuiler.Append($"\n");

                foreach (string translations in item.Translations)
                {
                    stringBuiler.Append($"{translations};");
                }
            }

            File.WriteAllText($"{LocalApplicationDirectory}{Name}.dat", stringBuiler.ToString());
        }
        public void Add(params string[] translations)
        {
            if (translations.Length % Languages.Length == 0)
            {
                for (int i = 0; i < translations.Length; i += Languages.Length)
                {
                    string[] wordTranslations = new string[Languages.Length];

                    for (int j = 0; j < Languages.Length; j++)
                    {
                        wordTranslations[j] = translations[i + j];
                    }

                    words.Add(new Word(wordTranslations));
                }
            }
            else
            {
                throw new ArgumentException("Invalid number of input strings.");
            }
        }
        public bool Remove(int translation, string word)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Translations[translation] == word)
                {
                    words.RemoveAt(i);

                    Save();

                    return true;
                }
            }

            return false;
        }
        public int Count()
        {
            return words.Count;
        }
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<Word> sortedList = words.OrderBy(t => t.Translations[sortByTranslation]).ToList();

            foreach (Word word in sortedList)
            {
                showTranslations(word.Translations);
            }
        }
        public Word GetWordToPractice()
        {
            int[] randLang = { random.Next(Languages.Length), random.Next(Languages.Length) };

            while (randLang[0] == randLang[1])
            {
                randLang[0] = random.Next(Languages.Length);
            }

            return new Word(randLang[0], randLang[1], words[random.Next(words.Count)].Translations);
        }
    }
}
