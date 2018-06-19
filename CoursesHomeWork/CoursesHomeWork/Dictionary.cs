using System;

namespace HomeWorkTask1
{
    internal class Dictionary
    {
        public Languages Language { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"{Language.ToString()}:";
        }

    }
}
