using System;
using System.IO;
using System.Linq;

namespace CSharpLaborationFourLibrary
{
    public class ConsoleHelper
    {
        public static void Lists()
        {
            if (Directory.GetFiles(WordList.LocalApplicationDirectory).Length != 0)
            {
                Console.WriteLine("Available lists:");
                foreach (string list in WordList.GetLists())
                {
                    Console.WriteLine(list);
                }
            }
            else
            {
                Console.WriteLine("Could not find any lists.");
            }
        }
        public static void New(string[] args)
        {
            if (args.Length > 3)
            {
                const int nameArg = 1;
                const int languageArg = 2;

                string name = args[nameArg];

                string[] languages = new string[args.Length - 2];

                for (int i = 0; i < args.Length - languageArg; i++)
                {
                    languages[i] = args[i + languageArg];
                }

                new WordList(name, languages).Save();

                Add(args);
            }
            else
            {
                if (args.Length < 2)
                {
                    Console.WriteLine("No list name was provided.");
                }
                
                Console.WriteLine("Please provide at least two languages.");
            }
        }
        public static void Add(string[] args)
        {
            if (args.Length > 1)
            {
                if (File.Exists($"{WordList.LocalApplicationDirectory}{args[1]}.dat"))
                {
                    WordList loadedList = WordList.LoadList(args[1]);

                    string[] wordInput = new string[loadedList.Languages.Length];

                    do
                    {
                        if (!wordInput.Contains(null))
                        {
                            loadedList.Add(wordInput);

                            loadedList.Save();
                        }

                        Console.WriteLine("Enter translations for the new word:");

                        for (int i = 0; i < wordInput.Length; i++)
                        {
                            Console.Write($"Enter {loadedList.Languages[i]} translation: ");
                            wordInput[i] = Console.ReadLine();
                            
                            if (wordInput[i] == "")
                            {
                                break;
                            }
                        }

                    } while (!wordInput.Contains(""));

                    loadedList.Save();
                }
                else
                {
                    Console.WriteLine("Could not find list.");
                }
            }
            else
            {
                Console.WriteLine("No list name was entered.");
            }
        }
        public static void Remove(string[] args)
        {
            if (args.Length > 3)
            {
                if (File.Exists($"{WordList.LocalApplicationDirectory}{args[1]}.dat"))
                {
                    WordList loadedList = WordList.LoadList(args[1]);

                    string[] words = new string[args.Length - 3];

                    for (int i = 0; i < words.Length; i++)
                    {
                        words[i] = args[i + 3];
                    }

                    for (int index = 0; index < loadedList.Languages.Length; index++)
                    {
                        if (loadedList.Languages[index] == args[2])
                        {
                            foreach (string word in words)
                            {
                                if (loadedList.Remove(index, word))
                                {
                                    Console.WriteLine($"Removed {word} and it's translations.");
                                }
                                else
                                {
                                    Console.WriteLine("Could not find word.");

                                    return;
                                }
                            }

                            loadedList.Save();

                            return;
                        }
                    }

                    Console.WriteLine($"Can not find language in file.");
                }
                else
                {
                    Console.WriteLine("Could not find file.");
                }
            }
            else
            {
                if (args.Length == 1)
                {
                    Console.WriteLine("Please provide list name, language and word.");
                    return;
                }
                else if (args.Length == 2)
                {
                    Console.WriteLine("Please provide language and word.");
                    return;
                }
                else
                {
                    Console.WriteLine("Please provide word.");
                }
            }
        }
        public static void Words(string[] args)
        {
            if (args.Length > 1)
            {
                if (File.Exists($"{WordList.LocalApplicationDirectory}{args[1]}.dat"))
                {
                    WordList loadedList = WordList.LoadList(args[1]);

                    if (loadedList.Count() != 0)
                    {
                        foreach (string language in loadedList.Languages)
                        {
                            Console.Write($"{language.ToUpper(),-15}");
                        }

                        int languageIndex = 0;

                        if (args.Length == 3)
                        {
                            for (int index = 0; index < loadedList.Languages.Length; index++)
                            {
                                if (loadedList.Languages[index] == args[2])
                                {
                                    languageIndex = index;
                                    break;
                                }
                            }
                        }

                        loadedList.List(languageIndex, translations =>
                        {
                            for (int i = 0; i < translations.Length; i++)
                            {
                                if (i % loadedList.Languages.Length == 0)
                                {
                                    Console.WriteLine();
                                }

                                Console.Write($"{translations[i],-15}");
                            }
                        });
                    }
                    else
                    {
                        Console.WriteLine("List doesn't contain any words.");
                    }
                }
                else
                {
                    Console.WriteLine("Could not find list.");
                }
            }
            else
            {
                Console.WriteLine("Please provide list name.");
            }
        }
        public static void Count(string[] args)
        {
            if (args.Length > 1)
            {
                if (File.Exists($"{WordList.LocalApplicationDirectory}{args[1]}.dat"))
                {
                    WordList loadedList = WordList.LoadList(args[1]);

                    Console.WriteLine($"There are {loadedList.Count()} words in {args[1]}.");
                }
                else
                {
                    Console.WriteLine("Could not find list.");
                }
            }
            else
            {
                Console.WriteLine("Enter a list name.");
            }
        }
        public static void Practice(string[] args)
        {   
            if (args.Length > 1)
            {
                if (File.Exists($"{WordList.LocalApplicationDirectory}{args[1]}.dat"))
                {
                    WordList loadedList = WordList.LoadList(args[1]);

                    int total = 0;
                    int correct = 0;

                    string wordInput = "";

                    do
                    {
                        Word word = loadedList.GetWordToPractice();

                        Console.Write(
                            $"Enter the {loadedList.Languages[word.ToLanguage]} " +
                            $"translation for the {loadedList.Languages[word.FromLanguage]} " +
                            $"word {word.Translations[word.FromLanguage]}: ");

                        wordInput = Console.ReadLine();

                        if (wordInput == word.Translations[word.ToLanguage])
                        {
                            Console.WriteLine("Correct answer.");

                            total++;
                            correct++;
                            continue;
                        }
                        else if (wordInput == "")
                        {
                            break;
                        }

                        Console.WriteLine("Wrong answer.");

                        total++;

                    } while (wordInput != "");

                    Console.WriteLine($"You answered {correct} correct out of {total} total.");
                }
                else
                {
                    Console.WriteLine("Could not find list.");
                }
            }
            else
            {
                Console.WriteLine("Enter a list name.");
            }
        }
        
        public static void Default()
        {
            Console.WriteLine(
                "Use any of the following commands:\n" +
                "-lists\n" +
                "-new [list name] [language 1] [language 2] .. [langauge n]\n" +
                "-add [list name]\n" +
                "-remove [list name] [language] [word 1] [word 2] .. [word n]\n" +
                "-words[listname] [ sortByLanguage ]\n" +
                "-count [listname]\n" +
                "-practice [listname]");
        }
    }
}