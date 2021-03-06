using System;
using System.IO;
using CSharpLaborationFourLibrary;

namespace CSharpLaborationFourConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(WordList.LocalApplicationDirectory))
            {
                Directory.CreateDirectory(WordList.LocalApplicationDirectory);
            }

            #region Command Line input
            if (args.Length != 0)
            {
                switch (args[0].ToLower())
                {
                    case "-lists":
                        ConsoleHelper.Lists();
                        break;
                    case "-new":
                        ConsoleHelper.New(args);
                        break;
                    case "-add":
                        ConsoleHelper.Add(args);
                        break;
                    case "-remove":
                        ConsoleHelper.Remove(args);
                        break;
                    case "-words":
                        ConsoleHelper.Words(args);
                        break;
                    case "-count":
                        ConsoleHelper.Count(args);
                        break;
                    case "-practice":
                        ConsoleHelper.Practice(args);
                        break;
                    default:
                        ConsoleHelper.Default();
                        break;
                }
            }
            else
            {
                ConsoleHelper.Default();
            }
            #endregion
        }
    }
}