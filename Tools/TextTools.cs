using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class TextTools
    {
        public string Text { get; set; }
        public string GetWordsWithLengthN(int N)
        {
            string[] split = Text.Split(new char[] { ' ', ',', '.', ':', ';', '\'','"', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '{', '}', '[', ']', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '|', '>', '<', '/', '\\', '=', '-', '+', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> Words = new List<string>();
            for (int i = 0; i < split.Length; i++)
                if (split[i].Length == N)
                    Words.Add(split[i]);
            return string.Join(" ", Words);
        }

        public TextTools(string text) => Text = text;
    }
}
