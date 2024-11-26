using System;

namespace Proyecto_Estructura_Datos
{

    /// Provides words for the game.
    internal class WordProvider
    {
        private string[] words = 
        {
            "programming",
            "hangman",
            "algorithm",
            "developer",
            "software",
            "application",
            "database",
            "debugging",
            "compilation",
            "network",
            "coding",
            "refactoring",
            "interface",
            "repository",
            "framework",
            "version",
            "testing",
            "frontend",
            "backend",
            "toledo",
            "deployment",
            "automation"
        };

        private Random random;

        public WordProvider()
        {
            random = new Random();
        }

        /// Returns a random word from the list.
        public string GetRandomWord()
        {
            int index = random.Next(words.Length);
            return words[index];
        }
    }
}
