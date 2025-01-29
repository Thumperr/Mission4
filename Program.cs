using Mission4;

using System;
/*
 * Array of arrays (3x3)
 * Asterisks until Xs and Os
 * 
 */

using Mission4;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // Game board
        char currentPlayer = 'X';
        bool gameWon = false;
        char winner = 'N';
        int moves = 0;

        while (!gameWon && moves < 9)
        {
            Board.PrintBoard(board);
            Console.WriteLine($"Player {currentPlayer}, enter a position (1-9): ");

            // Get user input
            string input = Console.ReadLine();

            // Validate input
            if (!int.TryParse(input, out int choice) || choice < 1 || choice > 9)
            {
                Console.WriteLine("Please enter a valid number between 1 and 9.");
                continue;
            }

            // Check if the position is already taken
            if (board[choice - 1] == 'X' || board[choice - 1] == 'O')
            {
                Console.WriteLine("Position is already occupied. Try again!");
                continue;
            }

            // Update board if valid input
            board[choice - 1] = currentPlayer;
            moves++;

            // tuple assignment
            (gameWon, winner) = Board.CheckWinner(board);

            if (gameWon)
            {
                Board.PrintBoard(board);
                Console.WriteLine($"Player {winner} wins!");
                return;
            }

            // Switch player
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }

        // Draw condition
        Board.PrintBoard(board);
        Console.WriteLine("It's a draw!");
    }
}
