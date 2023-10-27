using System;
using System.Collections.Generic;

namespace ScriptureApp
{
    public class ScriptureLibrary
    {
        private List<Scripture> scriptures;
        private Random random;

        public ScriptureLibrary()
        {
            random = new Random();

            // Initialize the library with some scriptures
            scriptures = new List<Scripture>
            {
                new Scripture("For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.", new ScriptureReference("John", 3, 16)),
                new Scripture("The Lord is my shepherd, I lack nothing.", new ScriptureReference("Psalms", 23, 1)),
                new Scripture("I can do all things through Christ who strengthens me.", new ScriptureReference("Philippians", 4, 13)),
            };
        }

        public Scripture GetRandomScripture()
        {
            int index = random.Next(scriptures.Count);
            return scriptures[index];
        }
    }
}
