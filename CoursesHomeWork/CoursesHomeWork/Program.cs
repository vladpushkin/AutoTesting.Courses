using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkTask1
{
    internal static class Program
    {
        private static void Main()
        {
            DisplayLanguages();
            Console.WriteLine();
            var localLanguage = SelectLanguage();
            DisplayPhrases(localLanguage);
            Console.WriteLine();
            var selectPhrase = SelectPhrase(localLanguage);
            var targetLanguage = SelectLanguage();
            Translate(localLanguage, selectPhrase, targetLanguage);

            Console.ReadKey();
        }
        //Difine phrases for languges
        internal static readonly Dictionary[][] Phrases = {
            new[]
            {
                new Dictionary
                {
                    Language = Languages.English,
                    Text = "Hello!"
                },

                new Dictionary
                {
                    Language = Languages.French,
                    Text = "Bonjour!"
                }
            },

            new[]
            {
                new Dictionary
                {
                    Language = Languages.English,
                    Text = "How are you?"
                },

                new Dictionary
                {
                    Language = Languages.French,
                    Text = "Comment allez-vous?"
                }
            },

            new[]
            {
                new Dictionary
                {
                    Language = Languages.English,
                    Text = "Goodbye!"
                },

                new Dictionary
                {
                    Language = Languages.French,
                    Text = "Au revoir!"
                }
            }
        };

        //Display available languages
        private static void DisplayLanguages()
        {
            Console.WriteLine("There are the following languages:");

            foreach (var Lang in Enum.GetValues(typeof(Languages)))
                Console.WriteLine($"- {Lang}");

            Console.WriteLine();
        }

        //Select language
        private static Languages SelectLanguage()
        {
            Console.WriteLine("Select your language!");

            Languages selectedLocalLanguage;

            while (!Enum.TryParse(Console.ReadLine(), out selectedLocalLanguage))
            {
                Console.WriteLine("Invalid input,try again.");
            }
            return selectedLocalLanguage;
        }


        //Display phrases for the language
        private static void DisplayPhrases(Languages language)
        {
            Console.WriteLine("There are following phrases:");
            for (int i = 0; i < Phrases.Length; i++)
            {
                foreach (var phrase in Phrases[i])
                {
                    if (phrase.Language == language)
                    {
                        Console.WriteLine($"{i + 1}) {phrase}");
                    }
                }
            }
        }

        //Select a phrase for the language
        private static int SelectPhrase(Languages language)
        {
            Console.WriteLine("Select a phrase to translate:");

            int selectedPhrase;
            while (!int.TryParse(Console.ReadLine(), out selectedPhrase))
            {
                Console.WriteLine("Invalid input,try again.");
            }

            return selectedPhrase;
        }

        //Translate selected phrase to selected language
        private static void Translate(Languages localLanguage, int phrase, Languages targetLanguage)
        {
            Dictionary localPhrase = null, targetPhrase = null;
            foreach (var phr in Phrases[phrase - 1])
            {
                if (phr.Language == localLanguage)
                {
                    localPhrase = phr;
                }

                if (phr.Language == targetLanguage)
                {
                    targetPhrase = phr;
                }
            }
            Console.WriteLine($"Original phrase:\n{localPhrase}");
            Console.WriteLine($"Translated phrase:\n{targetPhrase}");
        }  
    }
}
