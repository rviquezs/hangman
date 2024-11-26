using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;

namespace Proyecto_Estructura_Datos
{
    internal class Game
    {
        private string wordToGuess;
        private char[] hiddenWord;
        private List<char> guessedLetters;
        private int lives;
        private string level;
        private int wrongGuesses;
        asciiArt art = new asciiArt();

        public Game(string word)
        {
            wordToGuess = word;
            hiddenWord = new char[word.Length];
            guessedLetters = new List<char>();
    
            Console.WriteLine(art.AsciiLogo);
            Console.WriteLine("Select a difficulty: ");
            Console.WriteLine("1. Level 1: 6 lives");
            Console.WriteLine("2. Level 2: 4 lives");
            Console.WriteLine("3. Level 3: 2 lives");
            Console.WriteLine("Type 1, 2 or 3");
            level = Console.ReadLine();

            // Initialize hidden word with underscores
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                hiddenWord[i] = '_';
            }
        }

        /// Starts the game loop.
        public void Start()
        {
            bool isGameWon = false;
            Console.Clear();

            try
            {
                switch (Convert.ToInt32(level))
                {
                    case 1: lives = 6; break;
                    case 2: lives = 4; break;
                    case 3: lives = 2; break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please select a valid difficulty");
                        Program.isRunning = true;
                        Thread.Sleep(2000); 
                        return;
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please enter a number between 1 and 3.");
                Thread.Sleep(2000);
                Console.Clear();
                return;
            }          
            
            while (lives > 0 && !isGameWon)
            {
                DisplayState();

                Console.Write("Enter a letter: ");
                string input = Console.ReadLine();

                // Validate input
                if (string.IsNullOrEmpty(input) || input.Length > 1)
                {
                    Console.WriteLine("Please enter a single letter.");
                    continue;
                }

                char guessedLetter = char.ToLower(input[0]);

                // Check if the letter was already guessed
                if (guessedLetters.Contains(guessedLetter))
                {
                    Console.WriteLine("You already guessed that letter. Try again.");
                    Thread.Sleep(2000);
                    wrongGuesses ++ ;
                    continue;
                }

                // Process the guessed letter
                guessedLetters.Add(guessedLetter);

                if (wordToGuess.Contains(guessedLetter))
                {
                    Console.WriteLine("Correct!");
                    RevealLetter(guessedLetter);
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    Thread.Sleep(1700);
                    lives--;
                }

                // Check if the player has won
                isGameWon = !new string(hiddenWord).Contains('_');
            }

            DisplayResult(isGameWon);
        }

        /// Reveals the guessed letter in the hidden word.
        private void RevealLetter(char guessedLetter)
        {
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == guessedLetter)
                {
                    hiddenWord[i] = guessedLetter;
                }
            }
        }

        /// Displays the current state of the game.
        private void DisplayState()
        {
            Console.Clear();
            Console.WriteLine(art.AsciiLogo);
            //DisplayHangman(wrongGuesses); Prints a hangman ascii art as the game progresses
            Console.WriteLine($"\nWord: {new string(hiddenWord)}");
            Console.WriteLine($"Lives remaining: {lives}");
            Console.WriteLine($"Guessed letters: {string.Join(", ", guessedLetters)}");
        }

        /// Displays the result of the game.
        private void DisplayResult(bool isGameWon)
        {
            if (isGameWon)
            {   
                Console.WriteLine("\n");
                Console.WriteLine(art.YouWin);
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine(art.GameOver);
                Console.Clear();
                Console.WriteLine(art.AsciiLogo);
            }
            else
            {   
                Console.WriteLine(art.YouLoose);
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine(art.GameOver);
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine(art.AsciiLogo);
                Thread.Sleep(1000);
                Console.WriteLine($"\nThe word was: {wordToGuess}");
            }
        }

        public void DisplayHangman(int wrongGuesses)
        {
            if (wrongGuesses >= 0 && wrongGuesses < art.HangmanPics.Length)
            {
                Console.WriteLine(art.HangmanPics[wrongGuesses]);
            }
            else
            {
                Console.WriteLine("Invalid number of wrong guesses.");
            }
        }
    }
}
