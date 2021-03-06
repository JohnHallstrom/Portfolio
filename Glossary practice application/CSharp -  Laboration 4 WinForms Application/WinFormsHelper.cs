using System;
using System.IO;
using System.Collections.Generic;

namespace CSharpLaborationFourLibrary
{
    public class WinFormsHelper
    {
        public static string[] Lists()
        {
            return WordList.GetLists();
        }
        public static int Count(string args)
        {
            WordList loadedList = WordList.LoadList(args);

            return loadedList.Count();
        }
        public static string[] Languages(string args)
        {
            WordList loadedList = WordList.LoadList(args);

            string[] languages = new string[loadedList.Languages.Length];

            for (int i = 0; i < languages.Length; i++)
            {
                languages[i] = loadedList.Languages[i];
            }

            return languages;
        }
        public static IEnumerable<string[]> AllWords(string args)
        {
            WordList loadedList = WordList.LoadList(args);
            int languageCount = loadedList.Languages.Length;

            List<string> wordList = new List<string>();

            loadedList.List(0, translations =>
            {
                for (int i = 0; i < translations.Length; i++)
                {
                    wordList.Add(translations[i]);
                }
            });

            for (int row = 0; row < wordList.Count / languageCount; row++)
            {
                string[] words = new string[languageCount];

                for (int column = 0; column < languageCount; column++)
                {
                    words[column] = wordList[(row * languageCount) + column].Capitalize();
                }

                yield return words;
            }
        }
        public static string[] SelectLanguageWords(string name, string language)
        {
            WordList loadedList = WordList.LoadList(name);

            List<string> wordList = new List<string>();

            int languageCount = loadedList.Languages.Length;
            int languageIndex = 0;

            for (int i = 0; i < loadedList.Languages.Length; i++)
            {
                if (loadedList.Languages[i] == language.ToLower())
                {
                    languageIndex = i;
                    break;
                }
            }

            loadedList.List(languageIndex, translations =>
            {
                for (int i = languageIndex; i < translations.Length; i += languageCount)
                {
                    wordList.Add(translations[i]);
                }
            });

            return wordList.ToArray();
        }
        public static void Remove(string name, Word wordToRemove)
        {
            WordList loadedList = WordList.LoadList(name);

            loadedList.Remove(0, wordToRemove.Translations[0]);
        }
        public static void DeleteList(string name)
        {
            File.Delete($"{WordList.LocalApplicationDirectory}{name}.dat");
        }
        public static void New(string name, string[] languages)
        {
            new WordList(name, languages).Save();

        }
        public static void Add(string name, string[] translations)
        {
            WordList loadedList = WordList.LoadList(name);

                loadedList.Add(translations);

            loadedList.Save();
        }
    }
}