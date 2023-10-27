namespace ScriptureApp
{
    public class Word
    {
        private string wordText;
        private bool isBlank;

        public Word(string wordText)
        {
            this.wordText = wordText;
            this.isBlank = false; // Word is not blank initially
        }

        public void MakeBlank()
        {
            this.isBlank = true;
        }

        public bool IsBlank()
        {
            return this.isBlank;
        }

        public string GetWord()
        {
            // Generate a blank line of underscores with the same length as the wordText
            return this.isBlank ? new string('_', this.wordText.Length) : this.wordText;
        }
    }
}
