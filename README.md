# Hangman Game in C# - Proyecto_Estructura_Datos

## Description
This is a simple implementation of the Hangman game in C#, implemented under the `Proyecto_Estructura_Datos` namespace. The game involves guessing a hidden word by suggesting letters. Each incorrect guess reduces the number of available lives. The game ends when either the word is guessed correctly or the player runs out of lives.

## Structure of the Game
The game is implemented in several parts:

1. **Program.cs**: Main entry point for the game that starts the game loop.
2. **Game.cs**: Contains the game logic such as managing the word, checking guesses, and tracking lives.
3. **WordManager.cs**: Handles random word selection from a predefined list.
4. **GameTests.cs**: Unit tests to verify the correctness of the game logic.

## Data Structures Used
- **List**: Used to store the guessed letters.
- **String**: Used to store the secret word.
- **Integer**: Used to track the number of lives.

## Additional Features
- Random word selection from a list.
- Display of guessed letters and remaining lives.
- Simple error handling for invalid inputs.

## How to Run
1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Build and run the `Program.cs`.

## Future Improvements
- Add difficulty levels with different word lists and life counts.
- Implement hints and scoring based on time and lives used.

## License
This project is licensed under the MIT License.
