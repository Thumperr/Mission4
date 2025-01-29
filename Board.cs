/*
    • Receive the “board” array from the driver class
    • Contain a method that prints the board based on the information passed to it
    • Contain a method that receives the game board array as input and returns if there is a
    winner and who it was
 */

namespace Mission4;

public class Board
{
    public void PrintBoard(Array[] board)
    {
        Console.WriteLine("| " + board[1] + " | " + board[2] + " | " + board[3] + " |");
        Console.WriteLine("|---------------|");
        Console.WriteLine("| " + board[4] + " | " + board[5] + " | " + board[5] + " |");
        Console.WriteLine("|---------------|");
        Console.WriteLine("| " + board[7] + " | " + board[8] + " | " + board[9] + " |");
        Console.WriteLine("|---------------|");
    }

    public (bool, char) CheckWinner(Array[] board)
    {
        bool winner = false;
        char currentPlayer = ' ';
        
        // Check each row for a winner, top to bottom
        if (board[0] == board[1] && board[0] == board[2] && board[1] == board[2])
        {
            winner = true;
            currentPlayer = char.Parse(board[0].ToString());
        }
        else if (board[3] == board[4] && board[3] == board[5] && board[4] == board[5])
        {
            winner = true;
            currentPlayer = char.Parse(board[3].ToString());
        }
        else if (board[6] == board[7] && board[6] == board[8] && board[7] == board[8])
        {
            winner = true;
            currentPlayer = char.Parse(board[6].ToString());
        }
        
        // Check each column for a winner, left to right
        if (board[0] == board[3] && board[0] == board[6] && board[3] == board[6])
        {
            winner = true;
            currentPlayer = char.Parse(board[0].ToString());
        }
        else if (board[1] == board[4] && board[1] == board[7] && board[4] == board[7])
        {
            winner = true;
            currentPlayer = char.Parse(board[1].ToString());
        }
        else if (board[2] == board[5] && board[2] == board[8] && board[5] == board[8])
        {
            winner = true;
            currentPlayer = char.Parse(board[2].ToString());
        }
        
        // Check each diagonal for a winner, top left to bottom right and top right to bottom left
        if (board[0] == board[4] && board[0] == board[8] && board[4] == board[8])
        {
            winner = true;
            currentPlayer = char.Parse(board[0].ToString());
        }
        else if (board[2] == board[4] && board[2] == board[6] && board[4] == board[6])
        {
            winner = true;
            currentPlayer = char.Parse(board[2].ToString());
        }

        return (winner, currentPlayer);
    }
}

