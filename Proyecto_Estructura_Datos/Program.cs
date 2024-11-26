using System;
using System.Threading;

namespace Proyecto_Estructura_Datos
{
    internal class Program
    {
        public static bool isRunning = false;
        static void Main(string[] args)
        {
            // Initialize
            asciiArt art = new asciiArt();
            WordProvider wordProvider = new WordProvider();
            string selectedWord = wordProvider.GetRandomWord();
            

            while (true)
            {
                if (isRunning == false)
                {
                    Console.WriteLine(art.Welcome);
                    Thread.Sleep(2000);
                    isRunning = true;
                }

                Console.Clear();
                Console.WriteLine(art.AsciiLogo);
                Console.WriteLine("Press any key to start");
                Console.WriteLine("Enter Q to quit the game");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    Console.Clear();
                    Console.WriteLine("Quitting Game ...");
                    Thread.Sleep(1000);
                    Console.WriteLine(art.bye);
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.Clear();
                    Game game = new Game(selectedWord);
                    game.Start();
                }
            }
        }
    }
}

