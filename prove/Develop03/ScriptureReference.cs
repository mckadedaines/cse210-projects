namespace ScriptureApp
{
    public class ScriptureReference
    {
        private string book;
        private int chapter;
        private int verseStart;
        private int? verseEnd;

        public ScriptureReference(string book, int chapter, int verse)
        {
            this.book = book;
            this.chapter = chapter;
            this.verseStart = verse;
            this.verseEnd = null;
        }

        public ScriptureReference(string book, int chapter, int verseStart, int verseEnd)
        {
            this.book = book;
            this.chapter = chapter;
            this.verseStart = verseStart;
            this.verseEnd = verseEnd;
        }

        public string GetReference()
        {
            if (verseEnd.HasValue)
            {
                return $"{book} {chapter}:{verseStart}-{verseEnd.Value}";
            }
            else
            {
                return $"{book} {chapter}:{verseStart}";
            }
        }
    }
}
