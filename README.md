# Math Game

This is a simple console-based math game implemented in C#. The game allows players to practice arithmetic operations at different difficulty levels and view their performance in previous games.

## How to Use

1. **Compile and Run:** Compile the code using a C# compiler such as Visual Studio or dotnet CLI. Then run the compiled executable.

2. **Menu Navigation:** Upon running the program, you'll see a menu with three options:
    - **Start Game:** Begin a new math game.
    - **View Previous Games:** View the results of previous games.
    - **Exit:** Quit the program.

3. **Starting a Game:**
    - Choose a difficulty level (easy, medium, or hard).
    - Enter the number of questions you want to answer.
    - Answer the arithmetic questions prompted by the program.

4. **Viewing Previous Games:**
    - This option displays the results of previous games, including the number of questions, correct answers, and time taken.

## Features
- **Difficulty Levels:** Players can choose between easy, medium, and hard difficulty levels, which affect the range of numbers used in the arithmetic questions.
- **Random Operations:** Each question involves a randomly selected arithmetic operation (+, -, *, /).
- **Scoring:** After answering the questions, players receive feedback on the number of correct answers and the time taken to complete the game.
- **View Previous Games:** Players can review their performance in previous games, including the number of questions attempted, correct answers, and time taken.

## Code Structure
- **Calculator Class:** Contains the main game logic, including menu navigation, starting a new game, and viewing previous games.
- **GameResult Class:** Represents the result of a single game, including the number of questions, correct answers, and time taken.

## Dependencies
- **System.Diagnostics:** Used for measuring time elapsed during gameplay.
- **System.Collections.Generic:** Used for working with lists.

## Contributors
- **Denis*
