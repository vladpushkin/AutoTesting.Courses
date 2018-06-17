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
            },
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

        //Select phrase for the language
        private static int SelectPhrase(Languages language)
        {
            Console.WriteLine("Please select a phrase:");

            int selectedPhrase;
            while (!int.TryParse(Console.ReadLine(), out selectedPhrase))
            {
                Console.WriteLine("Invalid input,try again.");
            }

            return selectedPhrase;
        }

        //Translate 
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

        public static void Main()
        {
            DisplayLanguages();
            var localLanguage = SelectLanguage();
            SelectPhrase(localLanguage);
            var selectPhrase = SelectPhrase(localLanguage);
            var targetLanguage = SelectLanguage();
            Translate(localLanguage, selectPhrase, targetLanguage);

            Console.ReadKey();
        }
    }
}
