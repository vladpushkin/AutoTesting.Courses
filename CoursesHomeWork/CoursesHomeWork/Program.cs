using System;
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
            var selectPhrase = SelectPhrase();
            var targetLanguage = SelectLanguage();
            Translate(localLanguage, selectPhrase, targetLanguage);
            Console.ReadKey();
        }

        internal static readonly Dictionary[][] Phrases = {
            new[]
            {
                new Dictionary
                {
                    Language = "English",
                    Text = "Hello!"
                },

                new Dictionary
                {
                    Language = "French",
                    Text = "Bonjour!"
                }
            },

            new[]
            {
                new Dictionary
                {
                    Language = "English",
                    Text = "How are you?"
                },

                new Dictionary
                {
                    Language = "French",
                    Text = "Comment allez-vous?"
                }
            },

            new[]
            {
                new Dictionary
                {
                    Language = "English",
                    Text = "Goodbye!"
                },

                new Dictionary
                {
                    Language = "French",
                    Text = "Au revoir!"
                }
            }
        };


        private static void DisplayLanguages()
        {
            Console.WriteLine("There are the following languages:");

            foreach (var c in Phrases.ToList().SelectMany(x => x).Select(x => x.Language).Distinct())
            {
                Console.WriteLine($"- {c}");
            }
            Console.WriteLine();
        }


        private static string SelectLanguage()
        {
            Console.WriteLine("Select your language!");

            var lang = Console.ReadLine();

            if (lang == "English" || lang == "French")
            {
                return lang;
            }

            Console.WriteLine("Invalid input,try again.");
            return SelectLanguage();
        }

        private static void DisplayPhrases(string language)
        {
            Console.WriteLine("There are following phrases:");
            for (int i = 0; i < Phrases.Length; i++)
            {
                foreach (var phrase in Phrases[i])
                {
                    if (phrase.Language == language)
                    {
                        Console.WriteLine($"{i + 1}) {phrase.Text}");
                    }
                }
            }
        }

        private static int SelectPhrase()
        {
            Console.WriteLine("Select a phrase to translate:");

            int selectedPhrase;
            while (!int.TryParse(Console.ReadLine(), out selectedPhrase))
            {
                Console.WriteLine("Invalid input,try again.");
            }

            return selectedPhrase;
        }


        private static void Translate(String localLanguage, int phrase, String targetLanguage)
        {
            Dictionary localPhrase = null, targetPhrase = null;
            try
            {
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
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception!");
            }
            Console.WriteLine($"Original phrase:\n{localPhrase?.Text}");
            Console.WriteLine($"Translated phrase:\n{targetPhrase?.Text}");
        }
    }
}
