using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkTask1
{
    internal static class Program

    {
        internal static readonly Dictionary[][] Phrases = {
            new[]
            {
                new Dictionary
                {
                    Language = Language.English,
                    Text = "Hello!"
                },

                new Dictionary
                {
                    Language = Language.French,
                    Text = "Bonjour!"
                }
            },

            new[]
            {
                new Dictionary
                {
                    Language = Language.English,
                    Text = "How are you?"
                },

                new Dictionary
                {
                    Language = Language.French,
                    Text = "Comment allez-vous?"
                }

            new[]
            {
                new Dictionary
                {
                    Language = Language.English,
                    Text = "Goodbye!"
                },

                new Dictionary
                {
                    Language = Language.French,
                    Text = "Au revoir!"
                },
            },
        };

        //Dispalay list of available languages
        private static void DisplayLanguages()
        {
            Console.WriteLine("Select language to view phrases:");

            foreach (var language in Phrases.Keys)
            {
                Console.WriteLine($"{(int)language} - {language}");
            }
        }

        //Locate list of phrases for languages
        private static string[] GetPhrases(int enumNumber)
        {
            foreach (var phrase in Phrases)
            {
                if ((int)phrase.Key == enumNumber)
                {
                    return phrase.Value;
                }
            }

            return null;
        }

        //Display available languages
        private static void DisplayLanguages()
        {
            Console.WriteLine("There are the following languages:");

            foreach (var Lang in Enum.GetValues(typeof(Language)))
                Console.WriteLine($"- {Lang}");

            Console.WriteLine();
        }



        //Select language
        private static Language SelectLanguage()
        {
            Console.WriteLine("Select your language!");

            Language selectedLocalLanguage;

            while (!Enum.TryParse(Console.ReadLine(), out selectedLocalLanguage))
            {
                Console.WriteLine("Invalid innput,try again.");
            }
            return selectedLocalLanguage;
        }

        //Select phrase for the language
        private static int SelectPhrase(Language language)
        {
            Console.WriteLine("Please select a phrase:");

            int selectPhrase;
            while (!int.TryParse(Console.ReadLine(), out selectPhrase))
            {
                Console.WriteLine("Invalid innput,try again.");
            }

            return selectPhrase;
        }
    }
}
