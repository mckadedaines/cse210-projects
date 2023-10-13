using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureApp
{
    public class Scripture
    {
        private string text;
        private ScriptureReference reference;
        private List<Word> words;

        public Scripture(string text, ScriptureReference reference)
        {
            this.text = text;
            this.reference = reference;
            this.words = new List<Word>();

            string[] wordTexts = text.Split(' ');
            foreach (string wordText in wordTexts)
            {
                Word word = new Word(wordText);
                words.Add(word);
            }
        }

        public void ReplaceWordsWithBlanks(int numberOfWords)
        {
            Random rand = new Random();
            List<int> indexes = new List<int>();

            // Get the count of non-blank words
            int nonBlankCount = words.Count(w => !w.IsBlank());

            // If there are fewer non-blank words than the desired number to replace,
            // we'll only replace the remaining non-blank words.
            int wordsToReplace = Math.Min(nonBlankCount, numberOfWords);

            while (indexes.Count < wordsToReplace)
            {
                int index = rand.Next(words.Count);
                if (!indexes.Contains(index) && !words[index].IsBlank())
                {
                    indexes.Add(index);
                }
            }

            foreach (int index in indexes)
            {
                words[index].MakeBlank();
            }
        }

        public bool AllWordsAreBlank()
        {
            return words.All(w => w.IsBlank());
        }

        public string GetFullScripture()
        {
            string currentText = string.Join(" ", words.Select(w => w.GetWord()));
            return $"{reference.GetReference()} {currentText}";
        }
    }
}
