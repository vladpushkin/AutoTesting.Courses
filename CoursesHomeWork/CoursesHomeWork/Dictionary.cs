using System.Collections.Generic;

namespace HomeWorkTask1
{
    internal enum Languages
    {
        English,
        German,
        Italian,
        Swedish
    }

    internal class Dictionary
    {
        Dictionary<Languages, string[]> Text = new Dictionary<Languages, string[]> {
            {
                Languages.English,
                new[] {
                    "Good afternoon",
                    "How are you?",
                    "Goodbye"
              }
            },
            {
                Languages.German,
                new[] {
                    "guten Tag",
                    "Wie sind Sie?",
                    "Abschied"
                }
            },
            {
                Languages.Italian,
                new[] {
                    "Buon pomeriggio",
                    "Come stai?",
                    "Addio"
                }
            },
            {
                Languages.Swedish,
                new[] {
                    "God eftermiddag",
                    "Hur är du?",
                    "Farväl"
                }
            }
        };
    }
}